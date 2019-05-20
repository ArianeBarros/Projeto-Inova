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
        // GET: Perfil
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
        public void SalvarDados(string img)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = (UsuarioI9)Session["usuarioLogado"];
            usu.imagem = img;
        }
    }
}