using System;
using System.Collections.Generic;
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
        public ActionResult SalvarDados(UsuarioI9 u, string imagee)
        {
            if (u.imagem == null)//mandar mensagemmmm
                return RedirectToAction("Index", "Perfil");

            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = (UsuarioI9)Session["usuarioLogado"];
            usu.imagem = u.imagem;

           return RedirectToAction("Index", "Perfil"); 
        }

        /*
         * public ActionResult SalvarDados(Usuario u, HttpPostedFileBase upload)
        {
            UsuarioDAO dao = new UsuarioDAO();
            //if (dao.BuscaPorEmail(user.Email) == null)
            //  return RedirectToAction("Home", "HomePagina");

            //if (ModelState.IsValid)
            //{
            if (upload != null)
            {
                string caminhoArquivo = null;
                var uploadPath = Server.MapPath("~/img/imgUsers");
                caminhoArquivo = Path.Combine(@uploadPath, user.NomeUsuario + Path.GetExtension(upload.FileName));

                string[] extensãoPermitida = { ".gif", ".png", ".jpeg", ".jpg" };

                for (int i = 0; i < extensãoPermitida.Length; i++)
                    if (Path.GetExtension(caminhoArquivo) == extensãoPermitida[i])
                    {
                        upload.SaveAs(caminhoArquivo);
                        break;
                    }
                user.ImgPerfil = "img/imgUsers/" + user.NomeUsuario + Path.GetExtension(upload.FileName);
            }
            else
            {
                user.ImgPerfil = "img/UsuarioPadrao.png";
            }
            dao.Adiciona(user);
            Session["emailUsuario"] = user.Email;
            Session["nomeUsuario"] = user.NomeUsuario;
            Session["imgPerfil"] = user.ImgPerfil;

            return RedirectToAction("Index", "Home");
            // }

            //return RedirectToAction("Cadastro", "Usuario");
        }
         * 
         * 
         * 
         * */
    }
}