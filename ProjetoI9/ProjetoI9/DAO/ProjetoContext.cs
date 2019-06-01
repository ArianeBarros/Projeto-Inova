using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoI9.Models;

namespace ProjetoI9.DAO
{
    public class ProjetoContext: DbContext
    {
        public DbSet<Sonho> Sonho { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<UsuarioI9> UsuarioI9 { get; set; }
        public DbSet<Noticia> Noticia { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=regulus.cotuca.unicamp.br;Initial Catalog=PR118201;User ID=PR118201;Password=PR118201");
        }
    }
}