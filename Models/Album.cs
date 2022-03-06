using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Lancamento { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
    }
}