using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoI9.Controllers
{
    public class SairDaPaginaController : Controller
    {
        // GET: SairDaPagina
        public ActionResult Index()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}