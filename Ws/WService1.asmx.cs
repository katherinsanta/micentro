using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos_Center;
using  System.Data.SqlClient;
namespace Ws
{
    /// <summary>
    /// Descripción breve de WService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WService1 : System.Web.Services.WebService
    {
        //DatosDataContext datos = new DatosDataContext();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

           [WebMethod]
        public bool loginADMI( string admi_user, string contrsena_admi)
        {
            SqlConnection conecion = new SqlConnection("Data Source=DESARROLLORS02;Initial Catalog=CentroComercial;User ID=sa;Password=RS123");
           SqlCommand cmd = new SqlCommand("select Usuario,Contrasena  from Usuarios where Usuario = '" + admi_user + "' and Contrasena='"+contrsena_admi+"'");
         
            

            cmd.Connection=conecion;
            conecion.Open();
           
            SqlDataReader  reader= cmd.ExecuteReader();
          
            
                if(reader.Read()!=false){

                    reader.Dispose();
                cmd.Dispose();
                return true;
            }
            else
            {
                return false;
            }

            
        
        
    }
    }
    }

