using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos_Center;

namespace Presentacion
{
    public partial class Sesion : System.Web.UI.Page
    {
        DatosDataContext ws = new DatosDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ws.IniciarSesion(Txt_Contrasena.Text, Txt_Usuario.Text);


            Response.Redirect("Eventos.aspx");
        }
    }
}