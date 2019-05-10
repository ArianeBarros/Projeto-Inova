﻿using System;
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
        public ActionResult SalvarDados(string img, string id)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = dao.BuscaPorId(Convert.ToInt32(id));
            usu.imagem = img;

            return RedirectToAction("Index", "Principal", new { usu.nome, usu.imagem, usu.id });
        }
    }
}