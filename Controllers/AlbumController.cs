using SistemaFooFaMvc.Models;
using SistemaFooFaMvc.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFooFaMvc.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(AlbumModel album)
        {
            try
            {
                AlbumRepository albumRepo = new AlbumRepository();

                if (albumRepo.AddAlbum(album))
                {
                    ViewBag.Message = "Album adicionado com sucesso!";
                }

                return View();
            }
            catch (SqlException ex)
            {

                return View();
            }
        }
    }
}