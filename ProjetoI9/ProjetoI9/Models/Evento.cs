using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoI9.Models
{
    public class Evento
    {
        public int id { get; set; }
        [Required]
        public string link { get; set; }
        [Required]
        public string imagem { get; set; }
        [Required]
        public string manchete { get; set; }
    }
}