using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using registroService = SDChat.ServicioRegistro;

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
    }
}
