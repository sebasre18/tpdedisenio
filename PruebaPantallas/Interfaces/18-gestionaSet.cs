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
    public partial class gestionaSet : Form
    {
        //Declaracion clase Competencia publica
        public Clases_de_entidad.Partido partidoSeleccionado = new Clases_de_entidad.Partido();
        public Clases_de_entidad.CompetenciaDeportiva competencia = new Clases_de_entidad.CompetenciaDeportiva();

        //Declaracion gestores publicos
        public Clases_de_control.GestorFixture gestFix = new Clases_de_control.GestorFixture();

        //Declaracion de variables publicas
        public int numeroRonda, numeroPartido;

        public gestionaSet()
        {
            InitializeComponent();
        }

        private void gestionaSet_Load(object sender, EventArgs e)
        {
            //Hace visibles la cantidad de sets especificados, el nombre de cada participante y
            //carga sus respectivos resultados
          /*  if (partidoSeleccionado._resultado._cantidad_set == 1)
            {
                groupBoxS2.Visible = false;
                groupBoxS3.Visible = false;
                groupBoxS4.Visible = false;
                groupBoxS5.Visible = false;
                groupBoxS6.Visible = false;
                groupBoxS7.Visible = false;
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 2)
            {
                groupBoxS3.Visible = false;
                groupBoxS4.Visible = false;
                groupBoxS5.Visible = false;
                groupBoxS6.Visible = false;
                groupBoxS7.Visible = false;
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 3)
            {
                groupBoxS4.Visible = false;
                groupBoxS5.Visible = false;
                groupBoxS6.Visible = false;
                groupBoxS7.Visible = false;
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();


                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 4)
            {
                groupBoxS5.Visible = false;
                groupBoxS6.Visible = false;
                groupBoxS7.Visible = false;
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                textBoxP1S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP1.ToString();
                textBoxP2S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S4.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S4.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 5)
            {
                groupBoxS6.Visible = false;
                groupBoxS7.Visible = false;
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                textBoxP1S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP1.ToString();
                textBoxP2S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP2.ToString();
                textBoxP1S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP1.ToString();
                textBoxP2S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S4.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S4.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S5.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S5.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 6)
            {
                groupBoxS7.Visible = false;
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                textBoxP1S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP1.ToString();
                textBoxP2S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP2.ToString();
                textBoxP1S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP1.ToString();
                textBoxP2S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP2.ToString();
                textBoxP1S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP1.ToString();
                textBoxP2S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S4.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S4.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S5.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S5.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S6.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S6.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 7)
            {
                groupBoxS8.Visible = false;
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                textBoxP1S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP1.ToString();
                textBoxP2S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP2.ToString();
                textBoxP1S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP1.ToString();
                textBoxP2S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP2.ToString();
                textBoxP1S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP1.ToString();
                textBoxP2S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP2.ToString();
                textBoxP1S7.Text = partidoSeleccionado._resultado._sets[6]._puntosP1.ToString();
                textBoxP2S7.Text = partidoSeleccionado._resultado._sets[6]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S4.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S4.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S5.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S5.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S6.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S6.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S7.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S7.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 8)
            {
                groupBoxS9.Visible = false;

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                textBoxP1S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP1.ToString();
                textBoxP2S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP2.ToString();
                textBoxP1S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP1.ToString();
                textBoxP2S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP2.ToString();
                textBoxP1S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP1.ToString();
                textBoxP2S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP2.ToString();
                textBoxP1S7.Text = partidoSeleccionado._resultado._sets[6]._puntosP1.ToString();
                textBoxP2S7.Text = partidoSeleccionado._resultado._sets[6]._puntosP2.ToString();
                textBoxP1S8.Text = partidoSeleccionado._resultado._sets[7]._puntosP1.ToString();
                textBoxP2S8.Text = partidoSeleccionado._resultado._sets[7]._puntosP2.ToString();


                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S4.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S4.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S5.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S5.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S6.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S6.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S7.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S7.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S8.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S8.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }
            else
            {
                //Si son 9 los sets especificados no oculta ningun groupBox

                textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                textBoxP1S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP1.ToString();
                textBoxP2S4.Text = partidoSeleccionado._resultado._sets[3]._puntosP2.ToString();
                textBoxP1S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP1.ToString();
                textBoxP2S5.Text = partidoSeleccionado._resultado._sets[4]._puntosP2.ToString();
                textBoxP1S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP1.ToString();
                textBoxP2S6.Text = partidoSeleccionado._resultado._sets[5]._puntosP2.ToString();
                textBoxP1S7.Text = partidoSeleccionado._resultado._sets[6]._puntosP1.ToString();
                textBoxP2S7.Text = partidoSeleccionado._resultado._sets[6]._puntosP2.ToString();
                textBoxP1S8.Text = partidoSeleccionado._resultado._sets[7]._puntosP1.ToString();
                textBoxP2S8.Text = partidoSeleccionado._resultado._sets[7]._puntosP2.ToString();
                textBoxP1S9.Text = partidoSeleccionado._resultado._sets[8]._puntosP1.ToString();
                textBoxP2S9.Text = partidoSeleccionado._resultado._sets[8]._puntosP2.ToString();

                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S4.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S4.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S5.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S5.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S6.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S6.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S7.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S7.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S8.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S8.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S9.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S9.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }*/
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Valida el ausente de los participantes
            if (checkBoxP1.Checked == true & checkBoxP2.Checked == true)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "Ambos participantes estan ausentes.";
                error.Show();
            }
            else if (checkBoxP1.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[0]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                gestFix.guardarResultadoGanador(partidoSeleccionado, partidoSeleccionado._resultado._ganador, competencia);
            }
            else if (checkBoxP2.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;
                partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[1]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                gestFix.guardarResultadoGanador(partidoSeleccionado, partidoSeleccionado._resultado._ganador, competencia);
            }
            else
            {
                if (partidoSeleccionado._resultado._cantidad_set == 1)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else if (partidoSeleccionado._resultado._cantidad_set == 2)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else if (partidoSeleccionado._resultado._cantidad_set == 3)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }

                }
                else if (partidoSeleccionado._resultado._cantidad_set == 4)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP1S4.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 4: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else if (partidoSeleccionado._resultado._cantidad_set == 5)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP1S4.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 4: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP1S5.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 5: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP1 = int.Parse(textBoxP1S5.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP2 = int.Parse(textBoxP2S5.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else if (partidoSeleccionado._resultado._cantidad_set == 6)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP1S4.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 4: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP1S5.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 5: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S6.Text) == int.Parse(textBoxP1S6.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 6: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP1 = int.Parse(textBoxP1S5.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP2 = int.Parse(textBoxP2S5.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP1 = int.Parse(textBoxP1S6.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP2 = int.Parse(textBoxP2S6.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else if (partidoSeleccionado._resultado._cantidad_set == 7)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP1S4.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 4: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP1S5.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 5: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S6.Text) == int.Parse(textBoxP1S6.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 6: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S7.Text) == int.Parse(textBoxP1S7.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 7: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP1 = int.Parse(textBoxP1S5.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP2 = int.Parse(textBoxP2S5.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP1 = int.Parse(textBoxP1S6.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP2 = int.Parse(textBoxP2S6.Text);
                        partidoSeleccionado._resultado._sets[6]._puntosP1 = int.Parse(textBoxP1S7.Text);
                        partidoSeleccionado._resultado._sets[6]._puntosP2 = int.Parse(textBoxP2S7.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else if (partidoSeleccionado._resultado._cantidad_set == 8)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP1S4.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 4: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP1S5.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 5: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S6.Text) == int.Parse(textBoxP1S6.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 6: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S7.Text) == int.Parse(textBoxP1S7.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 7: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S8.Text) == int.Parse(textBoxP1S8.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 8: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP1 = int.Parse(textBoxP1S5.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP2 = int.Parse(textBoxP2S5.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP1 = int.Parse(textBoxP1S6.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP2 = int.Parse(textBoxP2S6.Text);
                        partidoSeleccionado._resultado._sets[6]._puntosP1 = int.Parse(textBoxP1S7.Text);
                        partidoSeleccionado._resultado._sets[6]._puntosP2 = int.Parse(textBoxP2S7.Text);
                        partidoSeleccionado._resultado._sets[7]._puntosP1 = int.Parse(textBoxP1S8.Text);
                        partidoSeleccionado._resultado._sets[7]._puntosP2 = int.Parse(textBoxP2S8.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
                else
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP1S1.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 1: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP1S2.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 2: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP1S3.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 3: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP1S4.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 4: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP1S5.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 5: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S6.Text) == int.Parse(textBoxP1S6.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 6: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S7.Text) == int.Parse(textBoxP1S7.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 7: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S8.Text) == int.Parse(textBoxP1S8.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 8: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else if (int.Parse(textBoxP1S9.Text) == int.Parse(textBoxP1S9.Text))
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        error.MdiParent = principal.ActiveForm;
                        error.WindowState = FormWindowState.Maximized;
                        error.error2 = "SET 9: No pueden ser ambos valores iguales.";
                        error.Show();

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP1 = int.Parse(textBoxP1S5.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP2 = int.Parse(textBoxP2S5.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP1 = int.Parse(textBoxP1S6.Text);
                        partidoSeleccionado._resultado._sets[5]._puntosP2 = int.Parse(textBoxP2S6.Text);
                        partidoSeleccionado._resultado._sets[6]._puntosP1 = int.Parse(textBoxP1S7.Text);
                        partidoSeleccionado._resultado._sets[6]._puntosP2 = int.Parse(textBoxP2S7.Text);
                        partidoSeleccionado._resultado._sets[7]._puntosP1 = int.Parse(textBoxP1S8.Text);
                        partidoSeleccionado._resultado._sets[7]._puntosP2 = int.Parse(textBoxP2S8.Text);
                        partidoSeleccionado._resultado._sets[8]._puntosP1 = int.Parse(textBoxP1S9.Text);
                        partidoSeleccionado._resultado._sets[8]._puntosP2 = int.Parse(textBoxP2S9.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado._resultado._histResultado = new Clases_de_entidad.HistorialResultado(partidoSeleccionado._resultado._id_resultado, partidoSeleccionado._resultado._puntosP1, partidoSeleccionado._resultado._puntosP2, partidoSeleccionado._resultado._ganador, partidoSeleccionado._resultado._ausente, partidoSeleccionado._resultado._empate = false, partidoSeleccionado._resultado._cantidad_set, partidoSeleccionado._resultado._sets, partidoSeleccionado._id_partido, partidoSeleccionado._resultado._histResultado, DateTime.Now);
                        gestFix.guardarResultadoSets(partidoSeleccionado, partidoSeleccionado._resultado._sets, competencia);
                    }
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if (partidoSeleccionado._resultado._cantidad_set == 1)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();

                textBoxP1S1.Focus();

            }
            else if (partidoSeleccionado._resultado._cantidad_set == 2)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();

                textBoxP1S1.Focus();
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 3)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();

                textBoxP1S1.Focus();
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 4)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();
                textBoxP1S4.Clear(); textBoxP2S4.Clear();

                textBoxP1S1.Focus();
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 5)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();
                textBoxP1S4.Clear(); textBoxP2S4.Clear();
                textBoxP1S5.Clear(); textBoxP2S5.Clear();

                textBoxP1S1.Focus();
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 6)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();
                textBoxP1S4.Clear(); textBoxP2S4.Clear();
                textBoxP1S5.Clear(); textBoxP2S5.Clear();
                textBoxP1S6.Clear(); textBoxP2S6.Clear();

                textBoxP1S1.Focus();
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 7)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();
                textBoxP1S4.Clear(); textBoxP2S4.Clear();
                textBoxP1S5.Clear(); textBoxP2S5.Clear();
                textBoxP1S6.Clear(); textBoxP2S6.Clear();
                textBoxP1S7.Clear(); textBoxP2S7.Clear();

                textBoxP1S1.Focus();
            }
            else if (partidoSeleccionado._resultado._cantidad_set == 8)
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();
                textBoxP1S4.Clear(); textBoxP2S4.Clear();
                textBoxP1S5.Clear(); textBoxP2S5.Clear();
                textBoxP1S6.Clear(); textBoxP2S6.Clear();
                textBoxP1S7.Clear(); textBoxP2S7.Clear();
                textBoxP1S8.Clear(); textBoxP2S8.Clear();

                textBoxP1S1.Focus();
            }
            else
            {
                textBoxP1S1.Clear(); textBoxP2S1.Clear();
                textBoxP1S2.Clear(); textBoxP2S2.Clear();
                textBoxP1S3.Clear(); textBoxP2S3.Clear();
                textBoxP1S4.Clear(); textBoxP2S4.Clear();
                textBoxP1S5.Clear(); textBoxP2S5.Clear();
                textBoxP1S6.Clear(); textBoxP2S6.Clear();
                textBoxP1S7.Clear(); textBoxP2S7.Clear();
                textBoxP1S8.Clear(); textBoxP2S8.Clear();
                textBoxP1S9.Clear(); textBoxP2S9.Clear();

                textBoxP1S1.Focus();
            }
           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxP1S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP1S9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2S9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
