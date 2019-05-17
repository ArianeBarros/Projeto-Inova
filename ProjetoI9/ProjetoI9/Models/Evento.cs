using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoI9.Models
{
    public class Evento
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int idUsuario { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public string localizacao { get; set; }
        [Required]
        public string dia { get; set; }
        [Required]
        public string diaSemana { get; set; }
    }
}