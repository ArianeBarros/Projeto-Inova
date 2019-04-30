using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoI9.Models
{
    public class UsuarioI9
    {
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string senha { get; set; }
        [Required] //, [a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}
        public string email { get; set; }
        [Required]
        public DateTime dataNascimento{ get; set; }
        public string imagem { get; set; }
        public int pontuacao { get; set; }
    }
}