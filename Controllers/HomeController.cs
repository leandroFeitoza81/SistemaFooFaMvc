using SistemaFooFaMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFooFaMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {

            AlbumBusinessLayer albumBL = new AlbumBusinessLayer();
            Album album = albumBL.GetAlbumDetails(id);

            //ViewData["Album"] = album;
            ViewData["Header"] = "Album Details";

            return View();
        }
    }
}