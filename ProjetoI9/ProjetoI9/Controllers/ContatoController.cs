﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];

            if (usuario != null)
            {
                ViewBag.UsuarioLogado = usuario;

                return View();
            }
            else
            {
                UsuarioI9 usua = new UsuarioI9();
                usua.imagem = "n";
                ViewBag.UsuarioLogado = usua;
                return View();
            }
        }

        public ActionResult Erro()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }
        public ActionResult ContEnvia(Mensagem men)
        {
            MensagemDAO dao = new MensagemDAO();
            men.id = dao.Lista().Count+ 1;     
            dao.Adiciona(men);

            return RedirectToAction("Index");
        }
    }
}