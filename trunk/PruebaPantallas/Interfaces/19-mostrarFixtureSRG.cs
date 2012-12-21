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
    public partial class mostrarFixtureSRG : Form
    {
        //Declaracion de clases publicas
        public static Clases_de_entidad.CompetenciaDeportiva competenciaVerFix = new Clases_de_entidad.CompetenciaDeportiva();
        
        //Declaracion de variables
        public List<Clases_de_entidad.Ronda> ronda;
        public Clases_de_entidad.Partido partido;
        public int nPartidos, nRonda, nroPartidoSelec, nRondaTotal;
        public string numRonda, numPartido, estado;

        //Metodos
        public mostrarFixtureSRG()
        {
            InitializeComponent();
        }

        private void buttonModRdo_Click(object sender, EventArgs e)
        {
            //Comprueba que tenga un partido seleccionado.            
            nroPartidoSelec = dataGridPartidos.CurrentRow.Index;            

            //Comprueba la modalidad de la competencia y su forma de puntuacion, dependiendo eso llama a las nuevas interfaces.
            if (competenciaVerFix._modalidad._nombreMod != "SISTEMA DE LIGA")
            {
                MessageBox.Show("Todavía no está implementada la función para doble y simple eliminación");
            }
            else if (competenciaVerFix._modalidad._nombreMod == "SISTEMA DE LIGA")
            {
                if (dataGridPartidos[1, nroPartidoSelec].Value != null)
                {
                    MessageBox.Show("Ya se ingreso un resultado.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Convert.ToInt32(comboBoxNroRonda.Text) != competenciaVerFix._fixture._rondaActual)
                        MessageBox.Show("No se pueden ingresar resultados en la ronda seleccionada.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        //Verifica si es primer o ultimo partido
                        int sinCargar = 0;
                        foreach (var unPartido in competenciaVerFix._fixture._rondas[0]._partidos)
                        {
                            if (unPartido._resultado != null)
                                sinCargar = 1;
                        }
                        if (sinCargar == 0)
                            estado = "EN DISPUTA";
                        else
                        {
                            sinCargar = 0;
                            foreach (var unPartido in competenciaVerFix._fixture._rondas[competenciaVerFix._fixture._rondaActual-1]._partidos)
                            {
                                if (unPartido._resultado != null)
                                    sinCargar++;
                            }
                            if ((sinCargar +1) == (competenciaVerFix._fixture._rondas[0]._partidos.Count))
                                estado = "RONDA"; //se pasa el string para que setee la ronda actual, aumenta
                            else
                            {
                                sinCargar = 0;
                                foreach (var unPartido in competenciaVerFix._fixture._rondas[competenciaVerFix._fixture._rondas.Count-1]._partidos)
                                {
                                    if (unPartido._resultado != null)
                                        sinCargar++;
                                }
                                if ((sinCargar - 1) == (competenciaVerFix._fixture._rondas[0]._partidos.Count))
                                    estado = "FINALIZADA";
                            }
                        }


                        //Verifica la forma de puntuacion de la competencia y llama a las distintas pantallas
                        if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "PUNTUACION")
                        {
                            this.Close();
                            gestionaPuntos gestPtos = new gestionaPuntos();
                            gestPtos.MdiParent = Interfaces.principal.ActiveForm;
                            gestPtos.partidoSeleccionado = competenciaVerFix._fixture._rondas[comboBoxNroRonda.SelectedIndex]._partidos[nroPartidoSelec];
                            gestPtos.competencia = competenciaVerFix;
                            gestPtos.estado = estado;
                            gestPtos.Show();
                        }
                        else if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "SETS")
                        {
                            this.Close();
                            gestionaSet gestSets = new gestionaSet();
                            gestSets.MdiParent = Interfaces.principal.ActiveForm;
                            gestSets.partidoSeleccionado = competenciaVerFix._fixture._rondas[comboBoxNroRonda.SelectedIndex]._partidos[nroPartidoSelec];
                            gestSets.competencia = competenciaVerFix;
                            gestSets.estado = estado;
                            gestSets.Show();
                        }
                        else if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "RESULTADO FINAL")
                        {
                            this.Close();
                            gestionaGanador gestGdor = new gestionaGanador();
                            gestGdor.MdiParent = Interfaces.principal.ActiveForm;
                            gestGdor.partidoSeleccionado = competenciaVerFix._fixture._rondas[comboBoxNroRonda.SelectedIndex]._partidos[nroPartidoSelec];
                            gestGdor.competencia = competenciaVerFix;
                            gestGdor.estado = estado;
                            gestGdor.Show();
                        }
                    }
                }
            }
        }

        private void mostrarFixtureSRG_Load(object sender, EventArgs e)
        {                                   
            //Llena el comoboBox de Nro de Ronda
            foreach (var unaRonda in competenciaVerFix._fixture._rondas)
            {
                comboBoxNroRonda.Items.Add(unaRonda._nro_ronda);
            }

            //Deja seleccionado por defecto la ronda actual
            comboBoxNroRonda.SelectedIndex = competenciaVerFix._fixture._rondaActual -1;

            //Asigna el nombre de la competencia al label.
            labelNombreComp.Text = competenciaVerFix._nombre;          
        }

        private void comboBoxNroRonda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //El nro seleccionado en el comboBox indica que ronda mostrar
            numRonda = comboBoxNroRonda.SelectedItem.ToString();
            if (comboBoxNroRonda.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe seleccionar una ronda", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Cambia el Text del groupBox del dataGrid
            groupBox2.Text = "Ronda "+ numRonda;            
        }

        private void dataGridPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPartidos.SelectedRows != null)
                buttonModRdo.Enabled = true;
            else
                buttonModRdo.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
            verCompetencia vc = new verCompetencia();
            vc.MdiParent = Interfaces.principal.ActiveForm;
            vc.competenciaVerComp = competenciaVerFix;
            vc.Show();
        }

        private void comboBoxNroRonda_SelectedValueChanged(object sender, EventArgs e)
        {
            cargaDataGrid(Convert.ToInt32(comboBoxNroRonda.Text));
        }


        //Carga el dataGrid
        private void cargaDataGrid(int nroRonda)
        {
            int fila = 0;
            foreach (var partido in competenciaVerFix._fixture._rondas[nroRonda-1]._partidos)
            {
                if (dataGridPartidos.Rows.Count < competenciaVerFix._fixture._rondas[nroRonda - 1]._partidos.Count)
                    dataGridPartidos.Rows.Add();
                //Asigna el nombre de los participantes al dataGrid
                dataGridPartidos[0, fila].Value = partido._pParticipantes[0]._participante._nombre;
                dataGridPartidos[3, fila].Value = partido._pParticipantes[1]._participante._nombre;

                //Asigna el resultado de cada participante
                if (partido._resultado != null)
                {
                    dataGridPartidos[1, fila].Value = partido._resultado._puntosP1;
                    dataGridPartidos[2, fila].Value = partido._resultado._puntosP2;
                }
                else
                {
                    dataGridPartidos[1, fila].Value = null;
                    dataGridPartidos[2, fila].Value = null;
                }
                fila++;
            }
        }
    }
}
