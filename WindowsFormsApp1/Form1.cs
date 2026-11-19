using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            if (string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Ingrese la contraseña. ");
                txtClave.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Ingrese el nombre de usuario. ");
                txtClave.Focus();
                return;
            }
            if (usuario == "Dilan" && clave == "olaolapasapasa")
            {
                MessageBox.Show("Bienvenido al sistema " + usuario);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. ");
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show(
                "¿Desea salir de la aplicacion?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave.Clear() ;
            txtUsuario.Clear() ;
            txtUsuario.Focus() ;
        }
    }
}
