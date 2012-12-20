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
                Clases_de_entidad.FormaPuntuacion formaP = new Clases_de_entidad.FormaPuntuacion();
                formaP._nombreForma = "PUNTUACION";

                /*nRondaTotal = competenciaVerFix._fixture._rondas.Count;               
                //Verifica si es primer o ultimo partido
                if (competenciaVerFix._fixture._rondas[0]._partidos[0]._resultado == null)
                {
                    //Actualiza el estado de la competencia en la BD a "En disputa"
                    competenciaVerFix._estado = "EN DISPUTA";
                    Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
                    competenciaABD.setEstado(competenciaVerFix._id_competencia, competenciaVerFix._estado);

                }
                else if (competenciaVerFix._fixture._rondas[nRondaTotal]._partidos[nPartidos]._resultado == null)
                {
                    //Actualiza el estado de la competencia en la BD a "Finalizada"
                    competenciaVerFix._estado = "FINALIZADA";
                    Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
                    competenciaABD.setEstado(competenciaVerFix._id_competencia, competenciaVerFix._estado);
                }*/

                //Verifica la forma de puntuacion de la competencia y llama a las distintas pantallas
                //if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "PUNTUACION")
                if (formaP._nombreForma == "PUNTUACION")
                {
                    gestionaPuntos gestPtos;
                    gestPtos = new gestionaPuntos();
                    //gestPtos.MdiParent = principal.ActiveForm;
                    //gestPtos.WindowState = FormWindowState.Maximized;
                    //gestPtos.partidoSeleccionado = competenciaVerFix._fixture._rondas[nRonda]._partidos[nroPartidoSelec];
                    //gestPtos.competencia = competenciaVerFix;
                    gestPtos.Show();
                }
                //if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "SETS")
                if (formaP._nombreForma == "SETS")
                {
                    gestionaSet gestSets;
                    //this.Close();
                    gestSets = new gestionaSet();
                    //gestSets.MdiParent = principal.ActiveForm;
                    //gestSets.WindowState = FormWindowState.Maximized;
                    //gestSets.partidoSeleccionado = competenciaVerFix._fixture._rondas[nRonda]._partidos[nroPartidoSelec];
                    //gestPtos.competencia = competenciaVerFix;
                    gestSets.Show();
                }
                //if (competenciaVerFix._modalidad._formaPuntuacion._nombreForma == "RESULTADO FINAL")
                if (formaP._nombreForma == "RESULTADO FINAL")
                {
                    gestionaGanador gestGdor;
                    gestGdor = new gestionaGanador();
                    //gestGdor.MdiParent = principal.ActiveForm;
                    //gestGdor.WindowState = FormWindowState.Maximized;
                    //gestGdor.partidoSeleccionado = competenciaVerFix._fixture._rondas[nRonda]._partidos[nroPartidoSelec];
                    //gestPtos.competencia = competenciaVerFix;
                    gestGdor.Show();
                }
            }
        }

        private void mostrarFixtureSRG_Load(object sender, EventArgs e)
        {
            
            //Codigo para comprobar q se llene correctamente

            competenciaVerFix._id_competencia = 3;
            competenciaVerFix._nombre = "COMPETENCIA DE PRUEBA";
            competenciaVerFix._estado = "EN DISPUTA";
            Clases_de_entidad.Deporte dep = new Clases_de_entidad.Deporte();
            dep._nombre = "FUTBOL";
            Clases_de_entidad.Modalidad mod = new Clases_de_entidad.Modalidad();
            mod._nombreMod = "LIGA";
            competenciaVerFix._modalidad = mod;
            //competenciaVerFix._participantes = new List<Clases_de_entidad.Participante>();
            Clases_de_entidad.Participante participante1 = new Clases_de_entidad.Participante();
            participante1._nombre = "PARTICIPANTE 1";
            participante1._id_participante = 1;
            Clases_de_entidad.Participante participante2 = new Clases_de_entidad.Participante();
            participante2._nombre = "PARTICIPANTE 2";
            participante2._id_participante = 1;
            Clases_de_entidad.Fixture fix = new Clases_de_entidad.Fixture();
            fix._rondas = new List<Clases_de_entidad.Ronda>();
            Clases_de_entidad.Ronda ronda1 = new Clases_de_entidad.Ronda();
            ronda1._nro_ronda = 1;
            Clases_de_entidad.Ronda ronda2 = new Clases_de_entidad.Ronda();
            ronda2._nro_ronda = 2;
            ronda1._partidos = new List<Clases_de_entidad.Partido>();
            Clases_de_entidad.Partido partido = new Clases_de_entidad.Partido();
            partido._pParticipantes = new List<Clases_de_entidad.PartidoParticipante>();
            Clases_de_entidad.PartidoParticipante pPart1 = new Clases_de_entidad.PartidoParticipante();
            Clases_de_entidad.PartidoParticipante pPart2 = new Clases_de_entidad.PartidoParticipante();
            pPart1._participante = participante1;
            pPart2._participante = participante2;
            partido._pParticipantes.Add(pPart2);
            partido._pParticipantes.Add(pPart1);
            fix._rondas.Add(ronda1);
            fix._rondas.Add(ronda2);
            fix._rondas[0]._partidos.Add(partido);

            dataGridPartidos.Rows.Add(6);

            fila = 0;
            //foreach (Clases_de_entidad.Partido partido in competenciaVerFix._fixture._rondas[nRonda]._partidos)
            foreach (Clases_de_entidad.Partido partidoo in fix._rondas[0]._partidos)
            {
                //Asigna el nombre de los participantes al dataGrid
                dataGridPartidos[0, fila].Value = partidoo._pParticipantes[0]._participante._nombre;
                dataGridPartidos[3, fila].Value = partidoo._pParticipantes[1]._participante._nombre;

                //Asigna el resultado de cada participante
                /*dataGridPartidos[1, fila].Value = partido._resultado._puntosP1;
                dataGridPartidos[2, fila].Value = partido._resultado._puntosP2;*/

                fila = fila + 1;
            }

            //Asigna el nombre de la competencia al label.
            labelNombreComp.Text = competenciaVerFix._nombre;

            //Llena el comoboBox de Nro de Ronda
            //foreach (Clases_de_entidad.Ronda nRonda in competenciaVerFix._fixture._rondas)
            foreach (Clases_de_entidad.Ronda nRonda in fix._rondas)
            {
                comboBoxNroRonda.Items.Add(nRonda._nro_ronda);
            }
            //Deja seleccionado por defecto la ronda actual
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
          /*  nPartidos = competenciaVerFix._fixture._rondas[nRonda]._partidos.Count;

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

            fila = 0;
            foreach (Clases_de_entidad.Partido partido in competenciaVerFix._fixture._rondas[nRonda]._partidos)
            {
                //Asigna el nombre de los participantes al dataGrid
                dataGridPartidos[0, fila].Value = partido._pParticipantes[0]._participante;
                dataGridPartidos[3, fila].Value = partido._pParticipantes[1]._participante;

                //Asigna el resultado de cada participante
                dataGridPartidos[1, fila].Value = partido._resultado._puntosP1;
                dataGridPartidos[2, fila].Value = partido._resultado._puntosP2;

                fila = fila + 1;
            }*/
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
            //verCompetencia verComp;
            this.Close();
            /*verComp = new verCompetencia();
            verComp.MdiParent = principal.ActiveForm;
            verComp.WindowState = FormWindowState.Maximized;
            verComp.competenciaVerComp = competenciaVerFix;
            verComp.Show();*/
        }

    }
}
