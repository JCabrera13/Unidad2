using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using u2_aspnetcoremvc_2.Models;

namespace u2_aspnetcoremvc_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]//cuando se hace por medio de get, se invoca el primero 
        public IActionResult Encuesta()
        {
            return View();
        }

        //sobre carga del endpoint
        [HttpPost] //cuando se hace por medio de get, se invoca el primero 
        public IActionResult Encuesta (ViewModelAlumnoEncuesta alumno)
        {
            Datos.AgregarRespuesta(alumno);
            //con el metodo view solo regresa codigo html hacia el navegador, pero no invoca ningun endpoint
            return View("Agradecimiento", alumno);
        }


        //[HttpGet]
        public IActionResult ListadoRespuestas()
        {
            return View("ListadoRespuestas", Datos.Respuestas);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
