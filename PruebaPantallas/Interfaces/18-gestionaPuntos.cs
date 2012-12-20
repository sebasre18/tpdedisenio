﻿using System;
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
        //Declaracion clases  publicas
        public Clases_de_entidad.Partido partidoSeleccionado = new Clases_de_entidad.Partido();
        public Clases_de_entidad.CompetenciaDeportiva competencia = new Clases_de_entidad.CompetenciaDeportiva();

        //Declaracion gestores publicos
        public Clases_de_control.GestorFixture gestFix = new Clases_de_control.GestorFixture();
        public Clases_de_control.GestorTabla gestTab = new Clases_de_control.GestorTabla();

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
            {
                textBoxP1.Text = "";
                textBoxP2.Text = "";
            }
        }

        private void textBoxP1_TextChanged(object sender, EventArgs e)
        {
            //Validacion de que el campo no sea nulo
            if (textBoxP1.TextLength == 0)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                //error.MdiParent = principal.ActiveForm;
                //error.WindowState = FormWindowState.Maximized;
                error.error2 = "El campo no puede estar vacio.";
                error.Show();
            }
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

        private void textBoxP2_TextChanged(object sender, EventArgs e)
        {
            //Validacion de que el campo no sea nulo
            if (textBoxP2.TextLength == 0)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                //error.MdiParent = principal.ActiveForm;
                //error.WindowState = FormWindowState.Maximized;
                error.error2 = "El campo no puede estar vacio.";
                error.Show();
            }
        }

        private void textBoxP1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxP2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxP2_KeyDown(object sender, KeyEventArgs e)
        {
            //Validacion de que el campo no sea nulo cuando se presiona "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxP2.TextLength == 0)
                {
                    mensajeTipo2 error;
                    error = new mensajeTipo2();
                    //error.MdiParent = principal.ActiveForm;
                    //error.WindowState = FormWindowState.Maximized;
                    error.error2 = "El campo no puede estar vacio.";
                    error.Show();
                }
            }
        }

        private void textBoxP1_KeyDown(object sender, KeyEventArgs e)
        {
            //Validacion de que el campo no sea nulo cuando se presiona "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxP1.TextLength == 0)
                {
                    mensajeTipo2 error;
                    error = new mensajeTipo2();
                    //error.MdiParent = principal.ActiveForm;
                    //error.WindowState = FormWindowState.Maximized;
                    error.error2 = "El campo no puede estar vacio.";
                    error.Show();
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Verifica que los campos no esten vacios
            if (textBoxP1.TextLength == 0)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                //error.MdiParent = principal.ActiveForm;
                //error.WindowState = FormWindowState.Maximized;
                error.error2 = "El campo 1 no puede estar vacio.";
                error.Show();
            }
            else if (textBoxP2.TextLength == 0)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                //error.MdiParent = principal.ActiveForm;
                //error.WindowState = FormWindowState.Maximized;
                error.error2 = "El campo 2 no puede estar vacio.";
                error.Show();
            }

            //Verifica los ausentes
            if (checkBoxP1.Checked == true & checkBoxP2.Checked == true)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                //error.MdiParent = principal.ActiveForm;
                //error.WindowState = FormWindowState.Maximized;
                error.error2 = "Ambos participantes estan ausentes.";
                error.Show();
            }
            else if (checkBoxP1.Checked == true)
            {
                //Asigna el ganador y el ausente
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[0]._participante;
                
                //Genera el historial de resultado y va a la BD
                partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
            }
            else if (checkBoxP2.Checked == true)
            {
                //Asigna el ganador y el ausente
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;
                partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[1]._participante;

                //Genera el historial de resultado y va a la BD
                partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
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

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                        gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                        gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                    }
                    else
                    {
                        mensajeTipo2 error;
                        error = new mensajeTipo2();
                        //error.MdiParent = principal.ActiveForm;
                        //error.WindowState = FormWindowState.Maximized;
                        error.error2 = "En la competencia no esta permitido el empate.";
                        error.Show();
                    }
                }
                else
                {
                    if (int.Parse(textBoxP1.Text) < int.Parse(textBoxP2.Text))
                    {
                        //Setea el ganador y los resultados de cada participante
                        partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                        partidoSeleccionado._resultado._puntosP1 = int.Parse(textBoxP1.Text);
                        partidoSeleccionado._resultado._puntosP2 = int.Parse(textBoxP2.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                        gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                        gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                    }
                    else if (int.Parse(textBoxP1.Text) > int.Parse(textBoxP2.Text))
                    {
                        //Setea el ganador y los resultados de cada participante
                        partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;
                        partidoSeleccionado._resultado._puntosP1 = int.Parse(textBoxP1.Text);
                        partidoSeleccionado._resultado._puntosP2 = int.Parse(textBoxP2.Text);

                        //Genera el historial de resultado y va a la BD
                        partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);
                        gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                        gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
                    }
                }
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


    }
}
