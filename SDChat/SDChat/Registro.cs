using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SDChat
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            OperacionesUsuario operacion = new OperacionesUsuario();
            int respuesta = operacion.registro(textUsuario.Text, textContrasena.Text, textConfirmar.Text);
            if(respuesta == 1){
                MessageBox.Show("Usuario registrado con éxito!");
                this.Close();
            } else if(respuesta == -1){
                MessageBox.Show("Las contraseñas no coinciden.");
                this.textContrasena.Text="";
                this.textConfirmar.Text="";
            }else if(respuesta == -2){
                MessageBox.Show("El usuario ya está registrado.");
                this.textUsuario.Text = "";
                this.textContrasena.Text = "";
                this.textConfirmar.Text = "";
            }else{
                MessageBox.Show("Error desconocido: " + respuesta);
                this.textUsuario.Text = "";
                this.textContrasena.Text = "";
                this.textConfirmar.Text = "";
            }
        }
    }
}
