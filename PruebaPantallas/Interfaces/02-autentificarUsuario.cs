using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPdeDiseño
{
    public partial class autentificarUsuario : Form
    {
        public Clases_de_entidad.Usuario usuarioNuevo = new Clases_de_entidad.Usuario();
        Clases_de_control.GestorUsuario gestorU = new Clases_de_control.GestorUsuario();

        public autentificarUsuario()
        {
            InitializeComponent();
        }

        private void autentificarUsuario_Load(object sender, EventArgs e)
        {
            tbEmail.Focus();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            usuarioNuevo._email = "EMAIL@HOTMAIL.COM";
            usuarioNuevo._contraseña = "PASS";
            Interfaces.principal.usuarioLogueadoP = usuarioNuevo;
            /*if (tbEmail.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Ninguno de los campos puede ser nulo.");
            }
            else
            {
                // Si el usuario no existe el sistema presenta un mensaje de error. Se vuelven a ingresar los datos.
                usuarioNuevo._email = "EMAIL@HOTMAIL.COM";
                usuarioNuevo._contraseña = "PASS";

                usuarioNuevo = gestorU.existeUsuario(tbEmail.Text);
                if (usuarioNuevo._email == " ")
                {
                    MessageBox.Show("Error. El Email no se encuentra registrado.");
                    tbEmail.Focus();
                }
                else
                {
                    // Queda creado el objeto logico usuario logueado. Se cierra la ventana de loguin.
                    this.Close();
                }
            }*/
            Interfaces.principal.ActiveForm.MainMenuStrip.Items[0].Enabled = false;
            Interfaces.principal.ActiveForm.MainMenuStrip.Items[1].Enabled = true;
            Interfaces.principal.ActiveForm.MainMenuStrip.Items[2].Enabled = false;
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    //Enfoco en el primer TextBox
                    this.tbEmail.Focus();
                }
            }
        }
    }
}
