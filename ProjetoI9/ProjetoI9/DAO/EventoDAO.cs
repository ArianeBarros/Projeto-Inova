using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoI9.DAO
{
    public class EventoDAO
    {
        public void Adiciona(Models.Noticia not)
        {
            using (var context = new ProjetoContext())
            {
                context.Noticia.Add(not);
                context.SaveChanges();
            }
        }
        public IList<Models.Noticia> Lista()
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Noticia.ToList();
            }
        }
        public Models.Noticia BuscaPorId(int id)
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Noticia.Where(p => p.id == id).FirstOrDefault();
            }
        }
        public void Atualiza(Models.Noticia not)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Entry(not).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}