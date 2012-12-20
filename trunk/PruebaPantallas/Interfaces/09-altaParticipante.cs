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
        public Clases_de_entidad.CompetenciaDeportiva competenciaAP = new Clases_de_entidad.CompetenciaDeportiva();        
        public Clases_de_control.GestorParticipante gestorP = new Clases_de_control.GestorParticipante();
        public Clases_de_entidad.Participante nuevoParticipanteAP = new Clases_de_entidad.Participante();
        public Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
        public Clases_ABD.ABDfixture fixtureABD = new Clases_ABD.ABDfixture();
        
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
                validarEmail(tbMail.Text);
            }
        
        private int validarCamposNulos()
        {
            if (tbNombre.Text == " ")
                return 1;
            if (tbMail.Text == " ")
                return 1;
            return 0;
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
            
           int error = 0;
           error = validarCamposNulos();
           Boolean nombreValido = gestorP.compararNombre(tbNombre.Text);
           Boolean emailValido = gestorP.compararMail(tbMail.Text);
                
           if (error == 1)
           {
               MessageBox.Show("Asegurese que ningun campo sea nulo");
               tbNombre.Focus();
           }
           else
           {
               if (nombreValido)
               {
                   if (emailValido)
                   {
                       competenciaAP._estado = "CREADA";
                       competenciaABD.setEstado(competenciaAP._id_competencia, "CREADA");
                       if (competenciaAP._fixture != null)
                       {
                           // Se borra el fixture.
                           fixtureABD.deleteFixture(competenciaAP);
                           MessageBox.Show("Se elimino el fixture de la competencia.");
                           // Se crea el participante.
                           nuevoParticipanteAP._nombre = tbNombre.Text;
                           nuevoParticipanteAP._email = tbMail.Text;
                           nuevoParticipanteAP._imagen = tbImagen.Text;
                           // Se agrega el participante a la competencia.
                           if (competenciaAP._participantes == null)
                           {
                               List<Clases_de_entidad.Participante> participantes = new List<Clases_de_entidad.Participante>();
                               participantes.Add(nuevoParticipanteAP);
                               competenciaAP._participantes = participantes;
                           }
                           else
                               competenciaAP._participantes.Add(nuevoParticipanteAP);

                       }
                       gestorP.guardar(nuevoParticipanteAP, competenciaAP._id_competencia);
                       MessageBox.Show("El participante se ha creado correctamente.");
                       this.Close();
                   }
                   else
                   {
                       MessageBox.Show("El email ya existe.");
                       tbNombre.Focus();
                   }
               }
               else
               {
                   MessageBox.Show("El nombre ya existe.");
                   tbNombre.Focus();
               }
            }
        }
    }
}


