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
                ViewBag.Noticia = not[0];
                return View();
            }
            else
                return RedirectToAction("Index", "Login");
        }

        public ActionResult SairPagina(string img, string i, string nomeController)
        {
            if (img == null)
                img = "/Imagens/imgPerfil.jpg";

            UsuarioI9DAO dao = new UsuarioI9DAO();
            if(i != null)
            {
                UsuarioI9 usu = dao.BuscaPorId(Convert.ToInt32(i));

                if(usu != null)
                {
                    usu.imagem = img;
                  return RedirectToAction("Index", nomeController, new { usu.nome, usu.imagem, usu.id });
                }
            }

            return RedirectToAction("Index", "Principal");

        }
    }
}