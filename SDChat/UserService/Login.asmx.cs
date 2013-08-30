using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace UserService
{
    /// <summary>
    /// Summary description for Login
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Login : System.Web.Services.WebService
    {

        [WebMethod]
        public int UsuarioLogin(string usuario, string contrasena)
        {
            string ruta = @"C:\SDChat2013\" + usuario + ".txt";
            if (!File.Exists(ruta))
            {
                //MessageBox.Show("El usuario no existe.");
                return 0;
            }
            else
            {
                if (!contrasena.Equals(File.ReadAllText(ruta)))
                {
                    //MessageBox.Show("Contraseña incorrecta.");
                    return -1;
                }
                else
                {
                    //this.Hide();
                    //new ChatGeneral().ShowDialog();
                    //this.Close();
                    return 1;
                }
            }
        }
    }
}
