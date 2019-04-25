using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoI9.Models;

namespace ProjetoI9.DAO
{
    public class UsuarioI9DAO
    {
        public void Adiciona(UsuarioI9 usu)
        {
            using (var context = new ProjetoContext())
            {
                context.UsuarioI9.Add(usu);
                context.SaveChanges();
            }
        }
        public IList<UsuarioI9> Lista()
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.UsuarioI9.ToList();
            }
        }
        public UsuarioI9 BuscaPorEmail(string email)
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.UsuarioI9.Where(p => p.email == email).FirstOrDefault();
            }
        }
        public void Atualiza(UsuarioI9 usu)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Entry(usu).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}
    