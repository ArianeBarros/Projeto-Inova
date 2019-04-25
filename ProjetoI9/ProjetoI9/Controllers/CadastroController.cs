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
            //ViewBag.UsuarioI9 = usu;
            return View();
        }

        public ActionResult HomeCadastrado(UsuarioI9 u)
        {     
            //gravar os dados no BD
            UsuarioI9DAO dao = new UsuarioI9DAO();
            IList<UsuarioI9> usu = dao.Lista();

            //criar objeto a partir dos dados do formulário
            u.id = usu.Count() + 1;
            u.pontuacao = 0;
            u.imagem = "~/Imagens/imgPerfil.jpg";
            
            foreach (UsuarioI9 a in usu)
            {
                if (a.email == u.email)
                    Erro();
            }

            //UsuarioI9 novoU = new UsuarioI9()
            //{
            //    id = usu.Count() + 1,
            //    nome = u.nome,
            //    senha = u.senha,
            //    dataNascimento = u.data,
            //    imagem = "~/Imagens/imgPerfil.jpg",
            //    email = u.email,
            //    pontuacao = 0
            //};

            dao.Adiciona(u);
            return View();            
        }        

        public ActionResult Erro()
        {
            return View();
        }
    }
}