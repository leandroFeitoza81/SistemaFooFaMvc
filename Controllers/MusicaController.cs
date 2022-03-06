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
    public class MusicaController : Controller
    {
        // GET: Musica
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(MusicaModel musica)
        {
            try
            {
                MusicaRepository musicRepo = new MusicaRepository();

                if (musicRepo.AddMusica(musica))
                {
                    ViewBag.Message = "Música adicionada com sucesso!";
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