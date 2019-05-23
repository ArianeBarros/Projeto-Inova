using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            string a = "o";
            if (Session["erro"] != null)
                a = Session["erro"].ToString();

            UsuarioI9DAO dao = new UsuarioI9DAO();
            IList<UsuarioI9> usu = dao.Lista();
            ViewBag.Erro = a;
            
            ViewData["usuarios"] = usu;
            ViewBag.QtdUsuarios = usu.Count();

            return View();
        }

        public ActionResult HomeLogado(UsuarioI9 u)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = dao.BuscaPorEmail(u.email);

            if (usu != null && usu.senha == u.senha)
            {
                Session["usuarioLogado"] = usu;
                return RedirectToAction("Index", "Principal");
            }
            else
            {
                Session["erro"] = "s" + u.email;
                return RedirectToAction("Index", "Login");
            }
           
        }
    }
}