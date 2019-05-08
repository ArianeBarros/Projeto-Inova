using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            IList<UsuarioI9> usu = dao.Lista();
            ViewBag.UsuarioI9 = usu;
            return View();
        }

        public ActionResult HomeLogado(UsuarioI9 u)
        {
            //criar objeto a partir dos dados do formulário
            
            //gravar os dados no BD
            UsuarioI9DAO dao = new UsuarioI9DAO();
            IList<UsuarioI9> usuLista = dao.Lista();

            bool existe = false;
            foreach(UsuarioI9 umUsuario in usuLista)
            {
                if (umUsuario.email == u.email)
                    existe = true;
            }

            if (!existe)
            {
                return RedirectToAction("Index", "Login");
            }               

            UsuarioI9 usu =  dao.BuscaPorEmail(u.email);
            ViewBag.Imagem = usu.imagem;

            if (usu != null && usu.senha == u.senha)
            {

                return RedirectToAction("Index", "Perfil", new { usu.nome, usu.imagem , usu.id});
            }                
            else //redirecionar para a camada de visualização
                return RedirectToAction("Index", "Login");
        }
    }
}