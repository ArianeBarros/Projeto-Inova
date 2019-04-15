using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using I9.Models;

namespace I9.DAO
{
    public class ProjetoContext : DbContext
    {
        public DbSet<UsuarioI9> UsuarioI9 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=regulus;Initial Catalog=PR118201;User ID=PR118201;Password=PR118201");
        }
    }
}