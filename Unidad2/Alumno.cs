using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unidad2
{
    public class Alumno
    {
        private int _intNumeroControl;

        public int NumeroControl
        {
            get { return _intNumeroControl; }
            set { _intNumeroControl = value; }
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