using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace I9.Models
{
    public class UsuarioI9
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string DataNascimento { get; set; }
        public string Imagem { get; set; }
        public int Pontuacao { get; set; }
    }
}