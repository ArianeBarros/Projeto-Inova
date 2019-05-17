using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            //UsuarioI9DAO dao = new UsuarioI9DAO();
            //IList<UsuarioI9> usu = dao.Lista();
            //ViewBag.UsuarioI9 = new UsuarioI9();
            return View();
        }

        public ActionResult HomeCadastrado(UsuarioI9 u)
        {           
            if (u != null && ModelState.IsValid)
            {
                UsuarioI9DAO dao = new UsuarioI9DAO();
                IList<UsuarioI9> usuLista = dao.Lista();

                bool existe = false;
                foreach(UsuarioI9 umUsuario in usuLista)
                {
                    if (umUsuario.email == u.email)
                    {
                        ViewBag.Nome = u.nome;
                        ViewBag.Data = u.dataNascimento;
                        ViewBag.Senha = u.senha;
                        existe = true;
                    }
                                               
                }
                if(existe)
                    return RedirectToAction("Index", "Cadastro");

                u.id = usuLista.Count() + 1;
                u.pontuacao = 0;
                u.imagem = "/Imagens/imgPerfil.jpg";

                dao.Adiciona(u);
                return RedirectToAction("Index", "Principal");
            }
            else
            {
                return RedirectToAction("Index", "Cadastro");
            }                    
        }
    }
}