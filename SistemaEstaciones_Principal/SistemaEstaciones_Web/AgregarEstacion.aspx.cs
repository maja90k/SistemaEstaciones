
using SistemaEstaciones_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaEstaciones_Web
{
    public partial class AgregarEstacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idEstacion = Convert.ToInt32(idEstacionNumb);
                String direccion = DireccionTxt.Text.Trim();

                Estacion es = new Estacion();
                es.IdEstacion = idEstacion;
                es.Direccion = direccion;
                new EstacionDAL().Add(es);            
            }
            else
            {

            }

        }
    }
}