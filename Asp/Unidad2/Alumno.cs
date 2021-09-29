using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unidad2
{
    public class Alumno
    {
        private string _strNoControl;

        public string NumeroControl
        {
            get { return _strNoControl; }
            set { _strNoControl = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strCarrera;

        public string Carrera
        {
            get { return _strCarrera; }
            set { _strCarrera = value; }
        }


    }
}