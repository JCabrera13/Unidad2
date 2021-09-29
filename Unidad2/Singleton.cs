using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unidad2
{
    public class Singleton
    {

        private static Singleton _instancia;

        public List<Alumno> alumnos = new List<Alumno>();


        private Singleton()
        {

        }


        public static Singleton getInstance()
        {
            if(_instancia == null)
            {
                _instancia = new Singleton();
            }

            return _instancia;


        }

    }
}