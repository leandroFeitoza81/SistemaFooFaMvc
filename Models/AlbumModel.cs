using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Models
{
    public class AlbumModel
    {
        [Display(Name="Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo do album é requerido.")]
        public string Titulo { get; set; }

      //  [Required(ErrorMessage = "Ano de lançamento do album é requerido.")]
        public int Lancamento { get; set; }
    }
}