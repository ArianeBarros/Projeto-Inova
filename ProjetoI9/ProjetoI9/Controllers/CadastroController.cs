using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            //UsuarioI9DAO dao = new UsuarioI9DAO();
            //IList<UsuarioI9> usu = dao.Lista();
            //ViewBag.UsuarioI9 = usu;
            return View();
        }

        public ActionResult HomeCadastrado(UsuarioI9 u)
        {           
            if (u != null && ModelState.IsValid)
            {
                UsuarioI9DAO dao = new UsuarioI9DAO();
                IList<UsuarioI9> usu = dao.Lista();

                u.id = usu.Count() + 1;
                u.pontuacao = 0;
                u.imagem = "~/Imagens/imgPerfil.jpg";

                dao.Adiciona(u);

                return RedirectToAction("HomeLogado", "Login");
            }
            else
            {
                return View("Index", "Cadastro");
            }                    
        }
    }
}