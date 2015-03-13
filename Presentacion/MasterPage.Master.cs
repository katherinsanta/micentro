using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MappsApp
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void login(object sender, EventArgs e)
        {


            Response.Redirect("Sesion.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            HttpContext.Current.Response.Redirect("Sesion.aspx", true);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}