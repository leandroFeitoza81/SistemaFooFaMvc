using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Models
{
    public class MusicaModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Single{ get; set; }
        public int Id_Album { get; set; }
    }
}