using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using registroService = SDChat.ServicioRegistro;
using loginService = SDChat.ServicioLogin;

namespace SDChat
{
    class OperacionesUsuario
    {
        public int registro(string nombre, string contrasena, string confirmacion)
        {
            int respuesta;
            registroService.RegistroSoapClient registroWeb = new registroService.RegistroSoapClient();
            respuesta = registroWeb.UsuarioRegistro(nombre, contrasena, confirmacion);
            return respuesta;
        }

        public int login(string nombre, string contrasena)
        {
            int respuesta;
            loginService.LoginSoapClient loginWeb = new loginService.LoginSoapClient();
            respuesta = loginWeb.UsuarioLogin(nombre, contrasena);
            return respuesta;
        }
    }
}
