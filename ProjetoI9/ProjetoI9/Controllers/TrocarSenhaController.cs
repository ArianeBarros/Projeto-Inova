﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoI9.DAO;
using ProjetoI9.Models;

namespace ProjetoI9.Controllers
{
    public class TrocarSenhaController : Controller
    {
        // GET: TrocarSenha
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TrocarSenha(UsuarioI9 u)
        {
            UsuarioI9DAO dao = new UsuarioI9DAO();
            UsuarioI9 usu = dao.BuscaPorEmail(u.email);

            if (usu != null)
            {
                usu.senha = u.senha;
                Session["usuarioLogado"] = usu;
                return RedirectToAction("Index", "Principal");
            }
            else
            {
                Session["erro"] = "email";
                
                return RedirectToAction("Index", "TrocarSenha");
            }
        }
    }
}