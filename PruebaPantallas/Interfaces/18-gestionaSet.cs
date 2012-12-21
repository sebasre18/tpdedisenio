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
        public Clases_de_control.GestorTabla gestTab = new Clases_de_control.GestorTabla();
        public Clases_ABD.ABDcompetencia compABD = new Clases_ABD.ABDcompetencia();
        public Clases_ABD.ABDfixture fixtureABD = new Clases_ABD.ABDfixture();

        public string estado;

        //Declaracion de variables publicas
        public int numeroRonda, numeroPartido, bandera;

        public gestionaSet()
        {
            InitializeComponent();
        }

        private void gestionaSet_Load(object sender, EventArgs e)
        {
            if (partidoSeleccionado._resultado == null)
            {
                bandera = 1;
            }

            //Hace visibles la cantidad de sets especificados, el nombre de cada participante y
            //carga sus respectivos resultados
            if (competencia._modalidad._formaPuntuacion._cantidadSet == 3)
            {
                groupBoxS4.Enabled = false;
                groupBoxS5.Enabled = false;
                groupBoxS6.Enabled = false;
                groupBoxS7.Enabled = false;
                groupBoxS8.Enabled = false;
                groupBoxS9.Enabled = false;

                //Si existe un resultado previo se carga en pantalla.
                if (partidoSeleccionado._resultado != null)
                {
                    textBoxP1S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP1.ToString();
                    textBoxP2S1.Text = partidoSeleccionado._resultado._sets[0]._puntosP2.ToString();
                    textBoxP1S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP1.ToString();
                    textBoxP2S2.Text = partidoSeleccionado._resultado._sets[1]._puntosP2.ToString();
                    textBoxP1S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP1.ToString();
                    textBoxP2S3.Text = partidoSeleccionado._resultado._sets[2]._puntosP2.ToString();
                }
                else
                {
                    textBoxP1S1.Text = ""; textBoxP2S1.Text = "";
                    textBoxP1S2.Text = ""; textBoxP2S2.Text = "";
                    textBoxP1S3.Text = ""; textBoxP2S3.Text = "";
                }


                labelP1S1.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S1.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S2.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S2.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
                labelP1S3.Text = partidoSeleccionado._pParticipantes[0]._participante._nombre;
                labelP2S3.Text = partidoSeleccionado._pParticipantes[1]._participante._nombre;
            }

            else if (competencia._modalidad._formaPuntuacion._cantidadSet == 5)
            {
                groupBoxS6.Enabled = false;
                groupBoxS7.Enabled = false;
                groupBoxS8.Enabled = false;
                groupBoxS9.Enabled = false;

                //Si existe un resultado previo se carga en pantalla.
                if (partidoSeleccionado._resultado != null)
                {
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
                }
                else
                {
                    textBoxP1S1.Text = ""; textBoxP2S1.Text = "";
                    textBoxP1S2.Text = ""; textBoxP2S2.Text = "";
                    textBoxP1S3.Text = ""; textBoxP2S3.Text = "";
                    textBoxP1S4.Text = ""; textBoxP2S4.Text = "";
                    textBoxP1S5.Text = ""; textBoxP2S5.Text = "";
                }

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

            else if (competencia._modalidad._formaPuntuacion._cantidadSet == 7)
            {
                groupBoxS8.Enabled = false;
                groupBoxS9.Enabled = false;

                //Si existe un resultado previo se carga en pantalla.
                if (partidoSeleccionado._resultado != null)
                {
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
                }
                else
                {
                    textBoxP1S1.Text = ""; textBoxP2S1.Text = "";
                    textBoxP1S2.Text = ""; textBoxP2S2.Text = "";
                    textBoxP1S3.Text = ""; textBoxP2S3.Text = "";
                    textBoxP1S4.Text = ""; textBoxP2S4.Text = "";
                    textBoxP1S5.Text = ""; textBoxP2S5.Text = "";
                    textBoxP1S6.Text = ""; textBoxP2S6.Text = "";
                    textBoxP1S7.Text = ""; textBoxP2S7.Text = "";
                }

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
            
            else
            {
                //Si son 9 los sets especificados no oculta ningun groupBox
                //Si existe un resultado previo se carga en pantalla.
                if (partidoSeleccionado._resultado != null)
                {
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
                }
                else
                {
                    textBoxP1S1.Text = "";  textBoxP2S1.Text = "";
                    textBoxP1S2.Text = "";  textBoxP2S2.Text = "";
                    textBoxP1S3.Text = "";  textBoxP2S3.Text = "";
                    textBoxP1S4.Text = "";  textBoxP2S4.Text = "";
                    textBoxP1S5.Text = "";  textBoxP2S5.Text = "";
                    textBoxP1S6.Text = "";  textBoxP2S6.Text = "";
                    textBoxP1S7.Text = "";  textBoxP2S7.Text = "";
                    textBoxP1S8.Text = "";  textBoxP2S8.Text = "";
                    textBoxP1S9.Text = "";  textBoxP2S9.Text = "";
                }

                

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
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int setsG2, setsG1;

            if (bandera == 1)
            {
                partidoSeleccionado._resultado = new Clases_de_entidad.Resultado();
                partidoSeleccionado._resultado._cantidad_set = competencia._modalidad._formaPuntuacion._cantidadSet;
                partidoSeleccionado._resultado._sets = new List<Clases_de_entidad.Set>();
                for (short i = 0; i < partidoSeleccionado._resultado._cantidad_set; i++)
                {
                    Clases_de_entidad.Set set = new Clases_de_entidad.Set();
                    set._nroSet = i;
                    partidoSeleccionado._resultado._sets.Add(set);
                }
            }
            //Valida el ausente de los participantes
            if (checkBoxP1.Checked == true & checkBoxP2.Checked == true)
            {
                MessageBox.Show("Ambos participantes están ausentes", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkBoxP1.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[0]._participante;
            }
            else if (checkBoxP2.Checked == true)
            {
                partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;
                partidoSeleccionado._resultado._ausente = partidoSeleccionado._pParticipantes[1]._participante;
            }
            else
            {
                if (partidoSeleccionado._resultado._cantidad_set == 3)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP2S1.Text))
                    {
                        MessageBox.Show("SET 1: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP2S2.Text))
                    {
                        MessageBox.Show("SET 2: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP2S3.Text))
                    {
                        MessageBox.Show("SET 3: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = int.Parse(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = int.Parse(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = int.Parse(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = int.Parse(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                    }

                }
                
                else if (partidoSeleccionado._resultado._cantidad_set == 5)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP2S1.Text))
                    {
                        MessageBox.Show("SET 1: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP2S2.Text))
                    {
                        MessageBox.Show("SET 2: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP2S3.Text))
                    {
                        MessageBox.Show("SET 3: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP2S4.Text))
                    {
                        MessageBox.Show("SET 4: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP2S5.Text))
                    {
                        MessageBox.Show("SET 5: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        partidoSeleccionado._resultado._sets[0]._puntosP1 = Convert.ToInt32(textBoxP1S1.Text);
                        partidoSeleccionado._resultado._sets[0]._puntosP2 = Convert.ToInt32(textBoxP2S1.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP1 = Convert.ToInt32(textBoxP1S2.Text);
                        partidoSeleccionado._resultado._sets[1]._puntosP2 = Convert.ToInt32(textBoxP2S2.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP1 = int.Parse(textBoxP1S3.Text);
                        partidoSeleccionado._resultado._sets[2]._puntosP2 = int.Parse(textBoxP2S3.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP1 = int.Parse(textBoxP1S4.Text);
                        partidoSeleccionado._resultado._sets[3]._puntosP2 = int.Parse(textBoxP2S4.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP1 = int.Parse(textBoxP1S5.Text);
                        partidoSeleccionado._resultado._sets[4]._puntosP2 = int.Parse(textBoxP2S5.Text);
                    }
                }
                
                else if (partidoSeleccionado._resultado._cantidad_set == 7)
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP2S1.Text))
                    {
                        MessageBox.Show("SET 1: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP2S2.Text))
                    {
                        MessageBox.Show("SET 2: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP2S3.Text))
                    {
                        MessageBox.Show("SET 3: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP2S4.Text))
                    {
                        MessageBox.Show("SET 4: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP2S5.Text))
                    {
                        MessageBox.Show("SET 5: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S6.Text) == int.Parse(textBoxP2S6.Text))
                    {
                        MessageBox.Show("SET 6: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(textBoxP1S7.Text) == int.Parse(textBoxP2S7.Text))
                    {
                        MessageBox.Show("SET 7: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    }
                }
                
                else
                {
                    if (int.Parse(textBoxP1S1.Text) == int.Parse(textBoxP2S1.Text))
                    {
                        MessageBox.Show("SET 1: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S2.Text) == int.Parse(textBoxP2S2.Text))
                    {
                        MessageBox.Show("SET 2: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S3.Text) == int.Parse(textBoxP2S3.Text))
                    {
                        MessageBox.Show("SET 3: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S4.Text) == int.Parse(textBoxP2S4.Text))
                    {
                        MessageBox.Show("SET 4: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S5.Text) == int.Parse(textBoxP2S5.Text))
                    {
                        MessageBox.Show("SET 5: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S6.Text) == int.Parse(textBoxP2S6.Text))
                    {
                        MessageBox.Show("SET 6: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S7.Text) == int.Parse(textBoxP2S7.Text))
                    {
                        MessageBox.Show("SET 7: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S8.Text) == int.Parse(textBoxP2S8.Text))
                    {
                        MessageBox.Show("SET 8: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(textBoxP1S9.Text) == int.Parse(textBoxP2S9.Text))
                    {
                        MessageBox.Show("SET 9: No pueden ser ambos valores iguales", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    }
                }

                //Se calculan los sets ganados por cada participante
                setsG1 = 0; setsG2 = 0;
                foreach (Clases_de_entidad.Set set in partidoSeleccionado._resultado._sets)
                {
                    if (set._puntosP1 < set._puntosP2)
                        setsG2 = setsG2 + 1;
                    else
                        setsG1 = setsG1 + 1;
                }
                
                if (setsG1 < setsG2)
                    partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[1]._participante;
                else
                    partidoSeleccionado._resultado._ganador = partidoSeleccionado._pParticipantes[0]._participante;

                //Genera el resultado y va a la BD
                partidoSeleccionado = gestFix.guardaResultado(partidoSeleccionado);

                actualizarCompetencia();

                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[0]._participante, partidoSeleccionado._resultado, competencia);
                gestTab.actualizaRenglon(partidoSeleccionado._pParticipantes[1]._participante, partidoSeleccionado._resultado, competencia);
            }
            mostrarFixtureSRG mf = new mostrarFixtureSRG();
            mf.MdiParent = Interfaces.principal.ActiveForm;
            mostrarFixtureSRG.competenciaVerFix = competencia;
            mf.Show();
            this.Close();
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
            mostrarFixtureSRG mf = new mostrarFixtureSRG();
            mf.MdiParent = Interfaces.principal.ActiveForm;
            mf.Show();
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
