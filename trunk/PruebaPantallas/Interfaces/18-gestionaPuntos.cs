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
    public partial class gestionaPuntos : Form
    {
        public Clases_de_entidad.Partido partidoSeleccionado = new Clases_de_entidad.Partido();
        public Clases_de_entidad.CompetenciaDeportiva competencia = new Clases_de_entidad.CompetenciaDeportiva();
        public Clases_de_control.GestorFixture gestFix = new Clases_de_control.GestorFixture();
        public Clases_de_control.GestorTabla gestTab = new Clases_de_control.GestorTabla();
        public Clases_ABD.ABDcompetencia compABD = new Clases_ABD.ABDcompetencia();
        public Clases_ABD.ABDfixture fixtureABD = new Clases_ABD.ABDfixture();
        
        public string estado;

        public gestionaPuntos()
        {
            InitializeComponent();
        }

        private void gestionaPuntos_Load(object sender, EventArgs e)
        {
            //Asigna el nombre de los participantes y el resultado alamacenado.
            labelPart1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
            labelPart2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;

            //Si existe un resultado previo se carga en pantalla.
            if (partidoSeleccionado._resultado != null)
            {
                textBoxP1.Text = partidoSeleccionado._resultado._puntosP1.ToString();
                textBoxP2.Text = partidoSeleccionado._resultado._puntosP2.ToString();
            }
            else
                partidoSeleccionado._resultado = new Clases_de_entidad.Resultado();
        }

        private void textBoxP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limita la entrada solo a numeros
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limita la entrada solo a numeros
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }        
        

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Verifica que los campos no esten vacios
            if (((textBoxP1.Text == null) || (textBoxP2.Text == null)) && ((checkBoxP1.Checked == false && checkBoxP2.Checked == false)))
            {
                MessageBox.Show("Los campos no deben ser nulos", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            else
            {
                //Verifica los ausentes
                if (checkBoxP1.Checked == true && checkBoxP2.Checked == true)
                {
                    MessageBox.Show("Ambos participantes están ausentes", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checkBoxP1.Checked == true)
                {
                    //Asigna el ganador y el ausente
                    if (partidoSeleccionado._resultado._ganador == null)
                        partidoSeleccionado._resultado._ganador = new Clases_de_entidad.Participante();
                    if (partidoSeleccionado._resultado._ausente == null)
                        partidoSeleccionado._resultado._ausente = new Clases_de_entidad.Participante();
                    partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                    partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[0]._participante;

                    partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);

                    actualizarCompetencia();

                    gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                    gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                }
                else if (checkBoxP2.Checked == true)
                {
                    //Asigna el ganador y el ausente
                    if (partidoSeleccionado._resultado._ganador == null)
                        partidoSeleccionado._resultado._ganador = new Clases_de_entidad.Participante();
                    if (partidoSeleccionado._resultado._ausente == null)
                        partidoSeleccionado._resultado._ausente = new Clases_de_entidad.Participante();
                    partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;
                    partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[1]._participante;

                    partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);

                    actualizarCompetencia();

                    gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                    gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                }
                //Curso normal sin ausentes
                else
                {
                    //Verifica que se permita el empate
                    if (int.Parse(textBoxP1.Text) == int.Parse(textBoxP2.Text))
                    {
                        if (competencia._modalidad._empate == true)
                        {
                            partidoSeleccionado._resultado._empate = true;
                            partidoSeleccionado._resultado._puntosP1 = int.Parse(textBoxP1.Text);
                            partidoSeleccionado._resultado._puntosP2 = int.Parse(textBoxP2.Text);

                            partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);

                            actualizarCompetencia();

                            gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                            gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                        }
                        else
                        {
                            MessageBox.Show("En la competencia no esta permitido el empate", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (partidoSeleccionado._resultado._ganador == null)
                            partidoSeleccionado._resultado._ganador = new Clases_de_entidad.Participante();
                        if (int.Parse(textBoxP1.Text) < int.Parse(textBoxP2.Text))
                        {
                            //Setea el ganador y los resultados de cada participante
                            partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                            partidoSeleccionado._resultado._puntosP1 = int.Parse(textBoxP1.Text);
                            partidoSeleccionado._resultado._puntosP2 = int.Parse(textBoxP2.Text);

                            partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);

                            actualizarCompetencia();

                            gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                            gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                        }
                        else if (int.Parse(textBoxP1.Text) > int.Parse(textBoxP2.Text))
                        {
                            //Setea el ganador y los resultados de cada participante
                            partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;
                            partidoSeleccionado._resultado._puntosP1 = int.Parse(textBoxP1.Text);
                            partidoSeleccionado._resultado._puntosP2 = int.Parse(textBoxP2.Text);

                            partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);

                            actualizarCompetencia();

                            gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                            gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                        }
                    }
                }
                this.Close();
                mostrarFixtureSRG.competenciaVerFix = competencia;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxP1.Clear();
            textBoxP2.Clear();
            checkBoxP1.Checked = false;
            checkBoxP1.Checked = false;
            textBoxP1.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarCompetencia()
        {
            
            if ((estado == "EN DISPUTA") || (estado == "FINALIZADA"))
            {
                competencia._estado = estado;
                compABD.setEstado(competencia._id_competencia, competencia._estado);
            }
            else if (estado == "RONDA")
            {
                competencia._fixture._rondaActual++;
                fixtureABD.setRondaActual(competencia._fixture._id_fixture);
            }
        }
    }
}
