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

        //Declaracion de variables publicas
        public int numeroRonda, numeroPartido;

        public gestionaGanador()
        {
            InitializeComponent();
        }

        private void gestionaGanador_Load(object sender, EventArgs e)
        {
            //Asigna los nombres de los participantes
           // radioButtonP1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
           // radioButtonP2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Comprueba que radioButton esta seleccionado
            if (radioButtonP1.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                gestFix.guardarResultadoGanador(partidoSeleccionado, partidoSeleccionado._resultado._ganador, competencia);
            }
            else if (radioButtonP2.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                gestFix.guardarResultadoGanador(partidoSeleccionado, partidoSeleccionado._resultado._ganador, competencia);
            }
            else if (radioButtonEmpate.Checked == true)
            {
                //Valida que el empate sea permitido
                if (competencia._modalidad._empate == true)
                {
                    partidoSeleccionado._resultado._empate = true;

                    //Genera el historial de resultado y va a la BD
                    partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                    gestFix.guardarResultadoGanadorEmp(partidoSeleccionado, partidoSeleccionado._resultado._empate, competencia);
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

     }
}
