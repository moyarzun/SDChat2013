using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace UserService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Registro : System.Web.Services.WebService
    {

        [WebMethod]
        public int UsuarioRegistro(string nombre, string contrasena, string confirmacion)
        {
            string carpeta = @"C:\SDChat2013";
            string ruta = @"C:\SDChat2013\" + nombre + ".txt";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            if (!File.Exists(ruta))
            {
                if (contrasena.Equals(confirmacion, StringComparison.Ordinal))
                {
                    File.WriteAllText(ruta, contrasena);
                    return 1;
                }
                else
                {
                    //MessageBox.Show("Las contraseñas no coinciden.");
                    return -1;
                }
            }
            else
            {
                //MessageBox.Show("El usuario ya está registrado.");
                return -2;
            }
        }
    }
}