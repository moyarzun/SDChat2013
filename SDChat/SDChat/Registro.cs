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
            string carpeta = @"C:\SDChat2013";
            string ruta = @"C:\SDChat2013\" + textUsuario.Text + ".txt";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            else
            {

                if (!File.Exists(ruta))
                {
                    if (textContrasena.Text.Equals(textConfirmar.Text, StringComparison.Ordinal))
                    {
                        File.WriteAllText(ruta, textConfirmar.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                        textContrasena.Text = "";
                        textConfirmar.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya está registrado.");
                    textUsuario.Text = "";
                    textContrasena.Text = "";
                    textConfirmar.Text = "";
                }
            }
        }
    }
}
