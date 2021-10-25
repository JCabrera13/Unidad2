using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcore_mvc3.Models
{
    public static class Datos
    {
        private static List<Empleado> empleados = new List<Empleado>();

        public static IEnumerable<Empleado> Empleados => empleados;

        public static void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public static void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }

    }
}
