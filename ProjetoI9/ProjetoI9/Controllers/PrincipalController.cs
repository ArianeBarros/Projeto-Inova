using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;
using ProjetoI9.Filtros;
using System.Net;
using System.IO;

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
                //NoticiaDAO dao = new NoticiaDAO();
                //IList<Noticia> not = dao.Lista();
                //ViewBag.QuantasNot = not.Count();

                //ViewData["noticias"] = not;

                SonhoDAO daoS = new SonhoDAO();
                IList<Sonho> s = daoS.Lista();
                List<Sonho> l = new List<Sonho>();

                foreach (var a in s)
                {
                    if (a.idUsuario == usuario.id )
                        l.Add(a);
                }

                ViewBag.QuantosSonhos = l.Count();
                ViewData["sonhos"] = l;

                EventoDAO eveDAO = new EventoDAO();
                IList<Evento> e = eveDAO.Lista();
                List<Evento> clone = new List<Evento>();

                foreach (var a in e)
                {
                    if (a.idUsuario == usuario.id && SeForDessaSemana(a.dia))
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
            DateTime d = d = Convert.ToDateTime(not.dia);
            not.diaSemana = d.DayOfWeek.ToString();

            if (not.diaSemana == "Wednesday")
                not.diaSemana = "Quarta-Feira";
            else
            {
                if(not.diaSemana == "Monday")
                    not.diaSemana = "Segunda-Feira";
                else
                    if(not.diaSemana == "Tuesday")
                        not.diaSemana = "Terça-Feira";
                    else
                        if(not.diaSemana == "Thursday")
                            not.diaSemana = "Quarta-Feira";
                        else
                            if(not.diaSemana == "Friday")
                                not.diaSemana = "Sexta-Feira";
                            else
                                if(not.diaSemana == "Saturday")
                                    not.diaSemana = "Sábado";
                                else
                                    not.diaSemana = "Domingo";
            }

            dao.Adiciona(not);

            return RedirectToAction("Index", "Principal");
        }

        public bool SeForDessaSemana(string d)
        {
            string[] data = d.Split('/');
            string dia = data[0];

            if (dia[0] == '0')
                dia = dia[1].ToString();

            string mes = data[1];

            if (mes[0] == '0')
                mes = mes[1].ToString();

            string ano = data[2];

            if (DateTime.Today.Month.ToString() != mes || DateTime.Today.Year.ToString() != ano || DateTime.Today.Day.ToString().CompareTo(dia) > 0)
                return false;

            if(DateTime.Today.Day.ToString().CompareTo("21") >= 0)
                return true;
            else
            {
                int semana = DateTime.Today.Day + 7;

                if (Convert.ToUInt32(d) <= semana && Convert.ToUInt32(d) >= DateTime.Today.Day)
                    return true;
                else
                    return false;
            }
        }

        public ActionResult AdicionarSonho(Sonho sonho)
        {
            try
            {
                UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];
                SonhoDAO dao = new SonhoDAO();
                
                sonho.id = (dao.Lista()).Count() + 1;
                sonho.idUsuario = usuario.id;

                dao.Adiciona(sonho);

                return RedirectToAction("Index", "Principal");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Erro()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }
        
        public string PegarNoticia(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();

            using (Stream data = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(data);
                string resposta = reader.ReadToEnd();

                response.Close();

                return resposta;
            }
        }
    }
}