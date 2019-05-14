﻿using System;
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
        public int idUsuario { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public string localizacao { get; set; }
        [Required]
        public string quando { get; set; }
    }
}