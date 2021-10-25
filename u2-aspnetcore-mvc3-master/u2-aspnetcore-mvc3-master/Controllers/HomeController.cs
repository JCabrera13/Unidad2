using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using u2_aspnetcore_mvc3.Models;

namespace u2_aspnetcore_mvc3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult RegistrarEmpleado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarEmpleado(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                Datos.AgregarEmpleado(empleado);
                return View("RegistroExitoso", empleado);
            }
            else
            {
                return View();
            }

        }

        public IActionResult EditarEmpleado(int numEmpleado)
        {
            //Empleado empleado = new Empleado();

            //foreach (Empleado e in Datos.Empleados)
            //{
            //    if(e.NumeroEmpleado == numEmpleado)
            //    {
            //        empleado = e;
            //        break;
            //    }
            //}
            //                                          expresion lambd                     se regresa el primero
            Empleado empleado = Datos.Empleados.Where(e => e.NumeroEmpleado == numEmpleado).FirstOrDefault();
           return View(empleado);
        }

        [HttpPost]
        public IActionResult EditarEmpleado(Empleado empleado)
        {
            Empleado e = Datos.Empleados.Where(e => e.NumeroEmpleado == empleado.NumeroEmpleado).FirstOrDefault();
            e.NombreCompleto = empleado.NombreCompleto;
            e.Sueldo = empleado.Sueldo;
            e.HorasTrabajadas = empleado.HorasTrabajadas;
            e.Puesto = empleado.Puesto;

            return RedirectToAction("Respuestas");
        }

        public IActionResult EliminarEmpleado (int noEmpleado)
        {
            Empleado e = Datos.Empleados.Where(e => e.NumeroEmpleado ==noEmpleado).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmacionEliminarEmpleado(int numEmpleado)
        {
            Empleado e = Datos.Empleados.Where(e => e.NumeroEmpleado == numEmpleado).FirstOrDefault();
            //eliminar al empleado de la coleccion.
            Datos.EliminarEmpleado(e);
            return RedirectToAction("Respuestas");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[HttpGet]
        public IActionResult Respuestas()
        {
            return View("Respuestas", Datos.Empleados);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
