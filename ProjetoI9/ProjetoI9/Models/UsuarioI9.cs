using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoI9.Models
{
    public class UsuarioI9
    {
        public int cod { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento{ get; set; }
        public string imagem { get; set; }
        public int pontuacao { get; set; }
    }
}