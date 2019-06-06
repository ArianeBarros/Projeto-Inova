using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoI9.Models
{
    public class Mensagem
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string mensagem { get; set; }
    }
}