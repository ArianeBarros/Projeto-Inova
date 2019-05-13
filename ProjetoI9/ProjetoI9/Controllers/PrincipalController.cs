using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;
using ProjetoI9.Filtros;

namespace ProjetoI9.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            object usuario = Session["usuarioLogado"];
            ViewBag.UsuarioLogado = usuario;
            if (usuario != null)
            {
                NoticiaDAO dao = new NoticiaDAO();
                IList<Noticia> not = dao.Lista();
                ViewBag.QuantasNot = not.Count();
              
                ViewData["noticias"] = not;
                
                return View();
            }
            else
                return RedirectToAction("Index", "Login");
        }

        public void SairPagina(string img)
        {
            //object usuario = Session["usuarioLogado"];

            //if (img == null)
            //    img = "/Imagens/imgPerfil.jpg";

            //UsuarioI9DAO dao = new UsuarioI9DAO();
           
            //UsuarioI9 usu = dao.BuscaPorId(Convert.ToInt32(i));

            //    usu.imagem = img;

        }
    }
}