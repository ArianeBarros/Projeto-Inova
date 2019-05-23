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
        // GET: Login
        public ActionResult Index()
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            IList<UsuarioI9> usu = dao.Lista();
            ViewBag.UsuarioI9 = usu;
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
                if (usu == null)
                    Session["erro"] = "email";
                else
                    Session["erro"] = "senha";
                return RedirectToAction("Index", "Login");
            }               
        }
    }
}