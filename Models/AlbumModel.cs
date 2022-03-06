using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Lancamento { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }

    }
}