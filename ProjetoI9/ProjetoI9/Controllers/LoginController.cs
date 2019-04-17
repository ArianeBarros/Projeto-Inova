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
    }
}