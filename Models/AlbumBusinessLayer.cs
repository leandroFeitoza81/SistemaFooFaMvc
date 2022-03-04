using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Models
{
    public class AlbumBusinessLayer
    {

        public Album GetAlbumDetails(int Id)
        {
            Album album = new Album()
            {
                Id = Id,
                Titulo = "Foo Fighters",
                Lancamento = "1995",
            };

            return album;
        }
    }
}