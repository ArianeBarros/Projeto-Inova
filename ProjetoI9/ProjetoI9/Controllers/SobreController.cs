﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class SobreController : Controller
    {
        // GET: Sobre
        public ActionResult Index()
        {
            UsuarioI9 usuario = (UsuarioI9)Session["usuarioLogado"];

            if (usuario != null)
            {
                ViewBag.UsuarioLogado = usuario;

                return View();
            }
            else
                return RedirectToAction("Index", "Login");
        }

        public ActionResult Erro()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }

        
    }
}