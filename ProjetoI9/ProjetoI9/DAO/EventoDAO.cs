using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoI9.Models;

namespace ProjetoI9.DAO
{
    public class EventoDAO
    {
        public void Adiciona(Evento eve)
        {
            using (var context = new ProjetoContext())
            {
                context.Evento.Add(eve);
                context.SaveChanges();
            }
        }
        public IList<Evento> Lista()
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Evento.ToList();
            }
        }
        public Evento BuscaPorId(int id)
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Evento.Where(p => p.id == id).FirstOrDefault();
            }
        }
        public void Atualiza(Evento eve)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Entry(eve).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}