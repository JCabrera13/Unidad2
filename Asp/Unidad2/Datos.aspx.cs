using System;
using System.Collections.Generic;
using System.Data;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unidad2
{
    public partial class Datos : System.Web.UI.Page
    {
 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.NumeroControl = txtNoControl.Text;
            alumno.Nombre = txtNombre.Text;
            alumno.Carrera = cmboCarreras.SelectedValue;

            Singleton.getInstance().alumnos.Add(alumno);
            lblNoControl.Text = "Lista alumnos: " + Singleton.getInstance().alumnos.Count;

            DataTable dt = new DataTable();

            dt.Columns.Add("numerocontrol");
            dt.Columns.Add("nombre");
            dt.Columns.Add("carrera");

            foreach (Alumno miAlumno in Singleton.getInstance().alumnos)
            {
                dt.Rows.Add(new[] { miAlumno.NumeroControl, miAlumno.Nombre, miAlumno.Carrera });
            }

            dgalumnos.DataSource = dt;
            dgalumnos.DataBind();




        }
    }
}