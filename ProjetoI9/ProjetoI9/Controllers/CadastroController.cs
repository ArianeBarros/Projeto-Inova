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
            UsuarioI9DAO dao = new UsuarioI9DAO();
            IList<UsuarioI9> alu = dao.Lista();
            ViewBag.Alunos = alu;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(int id, string nome, string senha, DateTime data, string img, string e, int p)
        {
            //criar objeto a partir dos dados do formulário
            UsuarioI9 usu = new UsuarioI9()
            {
                id = id,
                nome = nome,
                senha = senha,
                dataNascimento = data,
                imagem = "~/Imagens/imgPerfil.jpg",
                email = e,
                pontuacao = 0
            };
            //gravar os dados no BD
            UsuarioI9DAO dao = new UsuarioI9DAO();
            dao.Adiciona(usu);
            //redirecionar para a camada de visualização
            return View();
        }
    }
}