using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SalvarDados(string img, string id, string cont)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = dao.BuscaPorId(Convert.ToInt32(id));

            return RedirectToAction("Index", cont, new { usu.nome, usu.imagem, usu.id });
        }
    }
}