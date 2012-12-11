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
        public Clases_de_entidad.CompetenciaDeportiva competenciaVerFix = new Clases_de_entidad.CompetenciaDeportiva();

        //Declaracion de variables
        public List<Clases_de_entidad.Ronda> ronda;
        public Clases_de_entidad.Partido partido;
        public int fila, nPartidos, nRonda, nroPartidoSelec, nRondaTotal;
        public string numRonda, numPartido;
        

        //Metodos
        public mostrarFixtureSRG()
        {
            InitializeComponent();
        }

        private void buttonModRdo_Click(object sender, EventArgs e)
        {
            //Comprueba que tenga un partido seleccionado.
            if (dataGridPartidos.SelectedRows == null)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "Debe seleccionar un partido.";
                error.Show();
            }
            else
            {
                numPartido = dataGridPartidos.CurrentRow.Index.ToString();
                nroPartidoSelec = Convert.ToInt32(numPartido);
            }
                
            //Comprueba la modalidad de la competencia y su forma de puntuacion, dependiendo eso llama a las nuevas interfaces.
            if (competenciaVerFix._modalidad._nombreMod != "LIGA")
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "Todavia no esta implementada esta funcion para Simple y Doble Eliminacion.";
                error.Show();
            }
            else if (competenciaVerFix._modalidad._nombreMod == "LIGA")
            {
                nRondaTotal = competenciaVerFix._fixture._rondas.Count;
                //Verifica si es primer o ultimo partido
                if (competenciaVerFix._fixture._rondas[0]._partidos[0]._resultado == null)
                {
                    //Actualiza el estado de la competencia en la BD a "En disputa"
                    competenciaVerFix._estado = "EN DISPUTA";
                        //FALTA LO DE LA BD

                }
                else if (competenciaVerFix._fixture._rondas[nRondaTotal]._partidos[nPartidos]._resultado == null)
                {
                    //Actualiza el estado de la competencia en la BD a "Finalizada"
                    competenciaVerFix._estado = "FINALIZADA";
                    //FALTA LO DE LA BD

                }

                //Verifica la forma de puntuacion de la competencia y llama a las distintas pantallas
                if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "PUNTUACION")
                {
                    gestionaPuntos gestPtos;
                    this.Close();
                    gestPtos = new gestionaPuntos();
                    gestPtos.MdiParent = principal.ActiveForm;
                    gestPtos.WindowState = FormWindowState.Maximized;
                    gestPtos.partidoSeleccionado = competenciaVerFix._fixture._rondas[nRonda]._partidos[nroPartidoSelec];
                    gestPtos.modalidadSeleccionado = competenciaVerFix._modalidad;
                    gestPtos.Show();
                }
                if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "SETS")
                {
                    gestionaSet gestSets;
                    this.Close();
                    gestSets = new gestionaSet();
                    gestSets.MdiParent = principal.ActiveForm;
                    gestSets.WindowState = FormWindowState.Maximized;
                    gestSets.partidoSeleccionado = competenciaVerFix._fixture._rondas[nRonda]._partidos[nroPartidoSelec];
                    gestSets.Show();
                }
                if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "RESULTADO FINAL")
                {
                    gestionaGanador gestGdor;
                    this.Close();
                    gestGdor = new gestionaGanador();
                    gestGdor.MdiParent = principal.ActiveForm;
                    gestGdor.WindowState = FormWindowState.Maximized;
                    gestGdor.partidoSeleccionado = competenciaVerFix._fixture._rondas[nRonda]._partidos[nroPartidoSelec];
                    gestGdor.modalidadSeleccionado = competenciaVerFix._modalidad;
                    gestGdor.Show();
                }
            }
        }

        private void mostrarFixtureSRG_Load(object sender, EventArgs e)
        {
            //Asigna el nombre de la competencia al label.
            labelNombreComp.Text = competenciaVerFix._nombre;

            //Llena el comoboBox de Nro de Ronda
            foreach (Clases_de_entidad.Ronda nRonda in competenciaVerFix._fixture._rondas)
            {
                comboBoxNroRonda.Items.Add(nRonda._nro_ronda);
            }
            //Deja seleccionado por defecto el primer item añadido
            comboBoxNroRonda.SelectedIndex = 0; 
           
        }

        private void comboBoxNroRonda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //El nro seleccionado en el comboBox indica que ronda mostrar
            numRonda = comboBoxNroRonda.SelectedItem.ToString();
            if (comboBoxNroRonda.SelectedIndex.Equals(-1))
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "Debe seleccionar una ronda.";
                error.Show();
            }

            //Cambia el Text del groupBox del dataGrid
            groupBox2.Text = "Ronda "+ numRonda;

            //Llena el dataGridPartidos
            nRonda = Convert.ToInt32(numRonda);
            fila = 0;
            nPartidos = competenciaVerFix._fixture._rondas[nRonda]._partidos.Count;
            //Agrega las lineas para los partidos
            if (nPartidos != 0)
                dataGridPartidos.Rows.Add(nPartidos);

            if (dataGridPartidos.RowCount == 0)
            {
                dataGridPartidos.Rows.Add(nPartidos);
            }
            else
            {
                while (dataGridPartidos.Rows.Count != 0)
                {
                    dataGridPartidos.Rows.Remove(dataGridPartidos.Rows[0]);
                }
                dataGridPartidos.Rows.Add(nPartidos);
            }

            foreach (Clases_de_entidad.Partido partido in competenciaVerFix._fixture._rondas[nRonda]._partidos)
            {
                //Asigna el nombre de los participantes al dataGrid
                dataGridPartidos[0, fila].Value = partido._pParticipantes[0]._participante;
                dataGridPartidos[3, fila].Value = partido._pParticipantes[1]._participante;

                //Asigna el resultado de cada participante
                dataGridPartidos[1, fila].Value = partido._resultado._puntosP1;
                dataGridPartidos[2, fila].Value = partido._resultado._puntosP2;

                fila = fila + 1;
            }
        }

        private void dataGridPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            verCompetencia verComp;
            this.Close();
            verComp = new verCompetencia();
            verComp.MdiParent = principal.ActiveForm;
            verComp.WindowState = FormWindowState.Maximized;
            verComp.competenciaVerComp = competenciaVerFix;
            verComp.Show();
        }

    }
}
