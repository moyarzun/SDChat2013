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
            string ruta = @"C:\SDChat2013\" + textUsuario.Text + ".txt";
            if (!File.Exists(ruta))
            {
                MessageBox.Show("El usuario no existe.");
            }
            else
            {
                if (!textContrasena.Text.Equals(File.ReadAllText(ruta)))
                {
                    MessageBox.Show("Contraseña incorrecta.");
                }
                else
                {
                    this.Hide();
                    new ChatGeneral().ShowDialog();
                    this.Close();
                }
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
