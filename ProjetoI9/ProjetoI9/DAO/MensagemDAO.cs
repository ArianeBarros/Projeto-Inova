using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoI9.Models;
using Microsoft.EntityFrameworkCore;
using System.Web;

namespace ProjetoI9.DAO
{
    public class MensagemDAO
    {
        public void Adiciona(Mensagem men)
        {
            using (var context = new ProjetoContext())
            {
                context.Mensagem.Add(men);
                context.SaveChanges();
            }
        }
        public IList<Mensagem> Lista()
        {
            using (var contexto = new ProjetoContext())
            {
                return contexto.Mensagem.ToList();
            }
        }
       
        public void Atualiza(Mensagem men)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Entry(men).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public bool Excluir(Mensagem men)
        {
            using (var contexto = new ProjetoContext())
            {
                contexto.Mensagem.Remove(men);
                contexto.SaveChanges();
                if (contexto.Mensagem.Contains<Mensagem>(men))
                    return false;
                else
                    return true;
            }
        }
    }
}