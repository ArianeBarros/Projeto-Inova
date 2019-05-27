using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class PerfilController : Controller
    {
        public ActionResult Index()
        {
            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];

            if (usuario != null)
            {
                ViewBag.UsuarioLogado = usuario;

                return View();
            }
            else
                return RedirectToAction("Index", "Login");
        }
        //public ActionResult SalvarDados(UsuarioI9 u)
        //{
        //    if (u.imagem == null)//mandar mensagemmmm
        //        return RedirectToAction("Index", "Perfil");

        //    UsuarioI9DAO dao = new UsuarioI9DAO();
        //    UsuarioI9 usu = (UsuarioI9)Session["usuarioLogado"];

        //    usu.imagem = u.imagem;

        //    dao.Atualiza(usu);

        //    return RedirectToAction("Index", "Perfil");
        //}

        public ActionResult TrocarSenha(UsuarioI9 u)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = (UsuarioI9)Session["usuarioLogado"];

            usu.senha = u.senha;

            dao.Atualiza(usu);

            return RedirectToAction("Index", "Perfil");
        }

        public ActionResult Erro()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult SalvarDados(UsuarioI9 u, HttpPostedFileBase upload)
        {
            if (u.imagem == null)//mandar mensagemmmm
                return RedirectToAction("Index", "Perfil");

            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = (UsuarioI9)Session["usuarioLogado"];

            //if (ModelState.IsValid)
            //{
                if (upload != null)
                {
                    string caminhoArquivo = null;
                    var uploadPath = Server.MapPath("~/Imagens");
                    caminhoArquivo = Path.Combine(@uploadPath, upload.FileName);

                    string[] extensaoPermitida = { ".gif", ".png", ".jpeg", ".jpg" };

                    for (int i = 0; i < extensaoPermitida.Length; i++)
                        if (Path.GetExtension(caminhoArquivo) == extensaoPermitida[i])
                        {
                            upload.SaveAs(caminhoArquivo);
                            break;
                        }
                    usu.imagem = "../Imagens/" + upload.FileName;
                }
            //}
            //else
            //    usu.imagem = u.imagem;
            dao.Atualiza(usu);
            return RedirectToAction("Index", "Perfil");
        }
    }
}