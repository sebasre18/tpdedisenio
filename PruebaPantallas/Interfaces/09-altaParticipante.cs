using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TPdeDiseño
{
    public partial class altaParticipante : Form
    {
        public Clases_de_entidad.CompetenciaDeportiva competenciaAltaPart = new Clases_de_entidad.CompetenciaDeportiva();
        public Clases_de_control.GestorParticipante gestorP = new Clases_de_control.GestorParticipante();
                
        
        public altaParticipante()
        {
            InitializeComponent();
        }

        private void altaParticipante_Load(object sender, EventArgs e)
        {
            
        }
        
        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbMail_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbImagen_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void simulaTab(KeyEventArgs e)
        {
            //El Enter simula el Tab (pasa al siguiente objeto)
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se ingresan solo caracteres alfanumericos.
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            {
                e.Handled = true;
            }
        }

        public static bool validarEmail(string email)
            {
                string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        
                if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
                else
                { return false; }
            }

        private void tbMail_KeyPress(object sender, KeyPressEventArgs e)
            {
                //validarEmail(tbMail.text);
            }

        private void bExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "*.jpg";
            BuscarImagen.FileName = this.tbImagen.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
     
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.tbImagen.Text = BuscarImagen.FileName;                
                String Direccion = BuscarImagen.FileName;
                this.pbImagen.ImageLocation = Direccion;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)

                {

                    c.Text = " ";

                    //Enfoco en el primer TextBox

                    this.tbNombre.Focus();
                }
             }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if ((competenciaAltaPart._estado == "CREADA") || (competenciaAltaPart._estado == "PLANIFICADA"))
                MessageBox.Show("No se pueden agregar participantes a la competencia.");
            else
            {
                bool nombreValido = gestorP.compararNombre(tbNombre.Text);
                if (nombreValido)
                {
                   bool emailValido = gestorP.compararMail(tbMail.Text);
                   if (emailValido == false)
                       MessageBox.Show("El email ya existe.");
                   else
                       {
                           /*Clases_de_entidad.Participante participante = gestorP.nuevoParticipante();
                           competenciaAltaPart._estado == "CREADA";
                           Clases_de_control.GestorCompetencia competencia = new Clases_de_control.GestorCompetencia();
                           //void estadoComp = Clases_de_control.GestorCompetencia.setEstado("CREADA");
                           bool validaFixture = (competenciaAltaPart._fixture != null);
                           if(validaFixture == true)
                           { Clases_de_control.GestorFixture gestFixture = new Clases_de_control.GestorFixture();
                               void borrado = gestFixture.borrarFixture(id_fixture);
                               MessageBox.Show("Se elimino el fixture de la competencia.");
                           }
                       bool terminado = Clases_de_control.GestorParticipante.guardar(participante);
                       MessageBox.Show("El participante se ha creado correctamente.");*/
                       } 
                }
                else
                    MessageBox.Show("El nombre ya existe.");
            }
        }
    }
}


