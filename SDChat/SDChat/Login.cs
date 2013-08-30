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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesUsuario operacion = new OperacionesUsuario();
            int respuesta = operacion.login(this.textUsuario.Text, this.textContrasena.Text);
            if (respuesta == 1)
            {
                this.Hide();
                new ChatGeneral().ShowDialog();
                this.Close();
            }
            else if (respuesta == 0)
            {
                MessageBox.Show("El usuario no existe.");
                this.textUsuario.Text = "";
                this.textContrasena.Text = "";
            }
            else if (respuesta == -1)
            {
                MessageBox.Show("La contraseña es incorrecta.");
                this.textContrasena.Text = "";
            }
            else
            {
                MessageBox.Show("Error desconocido: " + respuesta);
                this.textUsuario.Text = "";
                this.textContrasena.Text = "";
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            new Registro().ShowDialog();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
