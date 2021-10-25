using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcore_mvc3.Models
{
    public class Empleado
    {
        [Required (ErrorMessage ="Se necesita el numero de empleado")]
        public int? NumeroEmpleado { get; set; }
        [Required(ErrorMessage = "Se necesita el nombre del empleado")]
        public string NombreCompleto { get; set; }
        public double? Sueldo { get; set; }
        public int? HorasTrabajadas { get; set; }
        public string Puesto { get; set; }

        // ? --para que se puedan mandar aunque no tenga un valor -- se permiten nulos
    }
}
