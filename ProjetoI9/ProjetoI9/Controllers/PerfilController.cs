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
            object usuario = Session["usuarioLogado"];
            ViewBag.UsuarioLogado = usuario;
            return View();
        }
        public void SalvarDados(string img)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = (UsuarioI9)Session["usuarioLogado"];
            usu.imagem = img;
        }
    }
}