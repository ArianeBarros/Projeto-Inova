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
                    if (a.idUsuario == usuario.id)
                        l.Add(a);
                }

                ViewBag.QuantosSonhos = l.Count();
                ViewData["sonhos"] = l;

                EventoDAO eveDAO = new EventoDAO();
                IList<Evento> e = eveDAO.Lista();
                List<Evento> clone = new List<Evento>();

                foreach (var a in e)
                {
                    string[] data = (a.dia).Split('/');
                    string ano = data[2];
                    string mes = data[1];

                    if (mes[0] == '0')
                        mes = mes[1].ToString();

                    //if (DateTime.Today.Year.ToString().CompareTo(ano) > 0 || ('"' + DateTime.Today.Month.ToString() + '"').CompareTo(mes) > 0)
                    //    eveDAO.Excluir(a);
                    if (EhPassado(data[0], mes, ano, a.dia))
                        eveDAO.Excluir(a);
                    else
                        if (a.idUsuario == usuario.id && SeForDessaSemana(data[0], mes, ano, a.dia))
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
                if (not.diaSemana == "Monday")
                    not.diaSemana = "Segunda-Feira";
                else
                    if (not.diaSemana == "Tuesday")
                    not.diaSemana = "Terça-Feira";
                else
                        if (not.diaSemana == "Thursday")
                    not.diaSemana = "Quarta-Feira";
                else
                            if (not.diaSemana == "Friday")
                    not.diaSemana = "Sexta-Feira";
                else
                                if (not.diaSemana == "Saturday")
                    not.diaSemana = "Sábado";
                else
                    not.diaSemana = "Domingo";
            }

            dao.Adiciona(not);

            return RedirectToAction("Index", "Principal");
        }

        public bool SeForDessaSemana(string d, string m, string a, string data)
        {
            DateTime dataTabela = Convert.ToDateTime(data);
            DateTime intervalo = DateTime.Today.AddDays(7);

            int result = DateTime.Compare(dataTabela, DateTime.Today);
            int result2 = DateTime.Compare(dataTabela, intervalo);

            if (result >= 0 && result2 <= 0)
                return true;


            return false;           
        }

        public bool EhPassado(string d, string m, string a, string data)
        {
            DateTime d2 = Convert.ToDateTime(data);
            int result = DateTime.Compare(d2, DateTime.Today);

            if (result < 0)
                return true;

            return false;
        }

        public ActionResult AdicionarSonho(Sonho sonho)
        {
            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];
            SonhoDAO dao = new SonhoDAO();
            var lista = dao.Lista();

            int ultimoId = 0;
            if (lista.Count >= 1)
            {
                ultimoId = lista.ElementAt(lista.Count - 1).id;
            }
            sonho.id = ultimoId + 1;
            sonho.idUsuario = usuario.id;

            dao.Adiciona(sonho);

            return RedirectToAction("Index", "Principal");

        }

        public ActionResult Erro()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Salvar(Sonho sonho)
        {
            string aux = sonho.descricao;

            SonhoDAO daoS = new SonhoDAO();
            IList<Sonho> s = daoS.Lista();

            foreach (var a in s)
            {
                if (a.descricao == sonho.descricao)
                    daoS.Excluir(a);
            }

            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];
            usuario.pontuacao += 1;

            return RedirectToAction("Index", "Principal");
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