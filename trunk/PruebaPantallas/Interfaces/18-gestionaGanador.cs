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
    public partial class gestionaGanador : Form
    {
        //Declaracion clase Competencia publica
        public Clases_de_entidad.Partido partidoSeleccionado = new Clases_de_entidad.Partido();
        public Clases_de_entidad.CompetenciaDeportiva competencia = new Clases_de_entidad.CompetenciaDeportiva();

        //Declaracion gestores publicos
        public Clases_de_control.GestorFixture gestFix = new Clases_de_control.GestorFixture();
        public Clases_de_control.GestorTabla gestTab = new Clases_de_control.GestorTabla();

        //Declaracion de variables publicas
        public int numeroRonda, numeroPartido;

        public gestionaGanador()
        {
            InitializeComponent();
        }

        private void gestionaGanador_Load(object sender, EventArgs e)
        {
            //Asigna los nombres de los participantes
            radioButtonP1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
            radioButtonP2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;

            //Si existe un resultado previo se carga en pantalla.
            if (partidoSeleccionado._resultado != null)
            {
                if (partidoSeleccionado._resultado._ganador._id_participante == partidoSeleccionado._pParticipantes[0]._participante._id_participante)
                    radioButtonP1.Checked = true;
                else
                    radioButtonP2.Checked = true;
            }

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Comprueba que radioButton esta seleccionado
            if (radioButtonP1.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
            }
            else if (radioButtonP2.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
            }
            else if (radioButtonEmpate.Checked == true)
            {
                //Valida que el empate sea permitido
                if (competencia._modalidad._empate == true)
                {
                    partidoSeleccionado._resultado._empate = true;

                    //Genera el historial de resultado y va a la BD
                    partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                    gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                    gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                }
                else
                {
                    mensajeTipo2 error;
                    error = new mensajeTipo2();
                    error.MdiParent = principal.ActiveForm;
                    error.WindowState = FormWindowState.Maximized;
                    error.error2 = "En la competencia no esta permitido el empate.";
                    error.Show();
                }
            }
            else
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "Debe seleccionar una opcion.";
                error.Show();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //Quita la seleccion de algun radioButton
            radioButtonP1.Checked = false;
            radioButtonP2.Checked = false;
            radioButtonEmpate.Checked = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonEmpate_CheckedChanged(object sender, EventArgs e)
        {

        }

     }
}
