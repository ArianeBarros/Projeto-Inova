using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoI9.Models;

namespace ProjetoI9.DAO
{
    public class SonhoDAO
    {
        public void Adiciona(Sonho s)
        {
            using (var context = new ProjetoContext())
            {
                context.Sonho.Add(s);
                context.SaveChanges();
            }
        }
        public List<Sonho> Lista()
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Sonho.ToList();
            }
        }
        public Sonho BuscaPorId(int id)
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Sonho.Where(p => p.id == id).FirstOrDefault();
            }
        }
        public void Atualiza(Sonho s)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Entry(s).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Sonho s)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Sonho.Remove(s);
                contexto.SaveChanges();
            }
        }
    }
}
