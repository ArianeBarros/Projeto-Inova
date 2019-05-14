using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoI9.Models;


namespace ProjetoI9.DAO
{
    public class NoticiaDAO
    {

        public void Adiciona(Noticia not)
        {
            using (var context = new ProjetoContext())
            {
                context.Noticia.Add(not);
                context.SaveChanges();
            }
        }
        public IList<Noticia> Lista()
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Noticia.ToList();
            }
        }
        public Noticia BuscaPorId(int id)
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Noticia.Where(p => p.id == id).FirstOrDefault();
            }
        }
        public void Atualiza(Noticia not)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Entry(not).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}
