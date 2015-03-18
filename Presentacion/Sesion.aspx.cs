using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos_Center;
using System.Windows.Forms;

using Ws;



namespace Presentacion
{
    
    public partial class Sesion : System.Web.UI.Page
    {
        WService1  dao = new WService1();

       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        
       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            this.Session["islogin"] = Txt_Contrasena.Text;
            



            if (dao.InicioSesion(Txt_Usuario.Text, Txt_Contrasena.Text) == true)
            {
                Session["islogin"] = true;
                Response.Redirect("Index.aspx");

            }
            else
            {


                //Response.Write("<script language='JavaScript'>alert('No se pudo iniciar sesion !!!');</script>");

                MessageBox.Show("no se pudo inicion");
                return;


            }
            
             
        }
    }
}