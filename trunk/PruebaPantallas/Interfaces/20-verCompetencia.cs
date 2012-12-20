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
    public partial class verCompetencia : Form
    {
        //Declaracion de clase Competencia publica.
        public Clases_de_entidad.CompetenciaDeportiva competenciaVerComp = new Clases_de_entidad.CompetenciaDeportiva();
        

        //Declaracion de variables
        int rondaActual, nR=0;
        string cadena;

        public verCompetencia()
        {
            InitializeComponent();
        }

        private void verCompetencia_Load(object sender, EventArgs e)
        {
            /*
            //Codigo para comprobar q se llene correctamente
            
            competenciaVerComp._id_competencia = 3;
            competenciaVerComp._nombre = "COMPETENCIA DE PRUEBA";
            competenciaVerComp._estado = "CREADA";
            Clases_de_entidad.Modalidad mod = new Clases_de_entidad.Modalidad();
            mod._nombreMod = "LIGA";
            competenciaVerComp._modalidad = mod;
            competenciaVerComp._deporte = new Clases_de_entidad.Deporte();

            competenciaVerComp._participantes = new List<Clases_de_entidad.Participante>();
            for (short i = 1; i <= 5; i++)
            {
                Clases_de_entidad.Participante participante = new Clases_de_entidad.Participante();
                participante._nombre = "PARTICIPANTE" + i;
                participante._id_participante = i;
                competenciaVerComp._participantes.Add(participante);
            }*/

            
            //Asigna los labels de la pantalla
            labelDeporteComp.Text = competenciaVerComp._deporte._nombre;
            labelEstadoComp.Text = competenciaVerComp._estado;
            labelModComp.Text = competenciaVerComp._modalidad._nombreMod;
            labelNombreComp.Text = competenciaVerComp._nombre;
            
            //Completa los listBox
            foreach (Clases_de_entidad.Participante participante in competenciaVerComp._participantes)
            {
                listBoxParticipantes.Items.Add(participante._nombre);
            }


            for (int nroRonda = competenciaVerComp._fixture._rondaActual ; nroRonda <= competenciaVerComp._fixture._rondas.Count ; nroRonda++)
            {
                foreach (Clases_de_entidad.Partido partido in competenciaVerComp._fixture._rondas[nroRonda-1]._partidos)
                {
                    cadena = partido._pParticipantes[0]._participante._nombre + " - " + partido._pParticipantes[1]._participante._nombre;
                    listBoxProxEncuentros.Items.Add(cadena);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            generarFixture genFixture = new generarFixture();
            this.Close();
            genFixture.MdiParent = principal.ActiveForm;
            genFixture.competenciaGenFix = competenciaVerComp;
            genFixture.Show();
            
        }

        private void buttonVerFixture_Click_1(object sender, EventArgs e)
        {
            
            //Comprovar que exista el fixture
            if (competenciaVerComp._fixture != null)
            {
                //Llamada a la nueva interfaz.
                mostrarFixtureSRG mostrarFixture = new mostrarFixtureSRG();
                mostrarFixture.MdiParent = principal.ActiveForm;
                //mostrarFixture.WindowState = FormWindowState.Maximized;
                mostrarFixture.competenciaVerFix = competenciaVerComp;
                mostrarFixture.Show();
                this.Close();
            }
            else
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.error2 = "No existe un fixture generado.";
                error.Show();
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonParticipantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");
        }

        private void buttonTabla_Click(object sender, EventArgs e)
        {
            if (competenciaVerComp._tablaPosiciones != null)
            {
                string formPunt = competenciaVerComp._modalidad._formaPuntuacion._nombreForma;
                if (formPunt == "RESULTADO FINAL" || formPunt == "SETS")
                {
                    // Se llama a la interfaz ver tabla de posiciones sin goles.
                    Interfaces.mostrarTablaSG mtSG = new Interfaces.mostrarTablaSG();
                    mtSG.MdiParent = principal.ActiveForm;
                    mtSG.competenciaSG = this.competenciaVerComp;
                    mtSG.Show();
                    this.Close();
                }
                else
                {
                    // Se llama a la interfaz ver tabla de posiciones con goles.
                    Interfases.mostrarTablaCG mtCG = new Interfases.mostrarTablaCG();
                    mtCG.MdiParent = principal.ActiveForm;
                    mtCG.competenciaCG = this.competenciaVerComp;
                    mtCG.Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("No existe Tabla de Posiciones para esta competencia.");
        }
    }
        
}
