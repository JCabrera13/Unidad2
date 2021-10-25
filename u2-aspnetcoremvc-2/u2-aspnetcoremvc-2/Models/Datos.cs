using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcoremvc_2.Models
{
    public static class Datos
    {
        private static List<ViewModelAlumnoEncuesta> respuestas = new List<ViewModelAlumnoEncuesta>();


        //acceder a la lista mediante respuesta
        public static IEnumerable<ViewModelAlumnoEncuesta> Respuestas => respuestas;

        public static void AgregarRespuesta(ViewModelAlumnoEncuesta alumno)
        {
            respuestas.Add(alumno);
        }
    }
}
