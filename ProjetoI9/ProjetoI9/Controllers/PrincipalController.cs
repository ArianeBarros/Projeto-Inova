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
        public ActionResult Index()
        {
            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];
            ViewBag.UsuarioLogado = usuario;
            if (usuario != null)
            {
                NoticiaDAO dao = new NoticiaDAO();
                IList<Noticia> not = dao.Lista();
                ViewBag.QuantasNot = not.Count();

                ViewData["noticias"] = not;

                SonhoDAO daoS = new SonhoDAO();
                IList<Sonho> l = daoS.Lista();
                ViewBag.QuantosSonhos = l.Count();

                ViewData["sonhos"] = l;

                EventoDAO eveDAO = new EventoDAO();
                IList<Evento> e = eveDAO.Lista();
                List<Evento> clone = new List<Evento>();

                foreach (var a in e)
                {
                    if (a.idUsuario == usuario.id)
                        clone.Add(a);
                }

                ViewBag.QuantosEventos = clone.Count();
                ViewData["eventos"] = clone;

                return View();
            }
            else
                return RedirectToAction("Index", "Login");
        }

        public ActionResult AdicionarEvento(Evento not)
        {
            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];
            EventoDAO dao = new EventoDAO();

            not.idUsuario = usuario.id;
            not.id = (dao.Lista()).Count() + 1;

            dao.Adiciona(not);

            return RedirectToAction("Index", "Principal");
        }
    }
}