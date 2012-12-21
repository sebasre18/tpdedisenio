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
        int rondaActual, nR = 0;
        string cadena;

        public verCompetencia()
        {
            InitializeComponent();
        }

        private void verCompetencia_Load(object sender, EventArgs e)
        {
            //Asigna los labels de la pantalla
            labelDeporteComp.Text = competenciaVerComp._deporte._nombre;
            labelEstadoComp.Text = competenciaVerComp._estado;
            labelModComp.Text = competenciaVerComp._modalidad._nombreMod;
            labelNombreComp.Text = competenciaVerComp._nombre;

            //Completa los listBox
            foreach (Clases_de_entidad.Participante participante in competenciaVerComp._participantes)
            {
                if (participante._nombre != "EQUIPOFANTASMA")
                    listBoxParticipantes.Items.Add(participante._nombre);
            }

            if (competenciaVerComp._fixture != null)
            {
                for (int nroRonda = competenciaVerComp._fixture._rondaActual; nroRonda <= competenciaVerComp._fixture._rondas.Count; nroRonda++)
                {
                    foreach (Clases_de_entidad.Partido partido in competenciaVerComp._fixture._rondas[nroRonda - 1]._partidos)
                    {
                        cadena = partido._pParticipantes[0]._participante._nombre + " - " + partido._pParticipantes[1]._participante._nombre;
                        listBoxProxEncuentros.Items.Add(cadena);
                    }
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            generarFixture genFixture = new generarFixture();
            genFixture.MdiParent = Interfaces.principal.ActiveForm;
            genFixture.competenciaGenFix = competenciaVerComp;
            genFixture.Show();
        }

        private void buttonVerFixture_Click_1(object sender, EventArgs e)
        {
            //Comprovar que exista el fixture
            if (competenciaVerComp._fixture != null)
            {
                //Llamada a la nueva interfaz.
                this.Close();
                mostrarFixtureSRG mostrarFixture = new mostrarFixtureSRG();
                mostrarFixture.MdiParent = Interfaces.principal.ActiveForm;
                mostrarFixtureSRG.competenciaVerFix = competenciaVerComp;
                mostrarFixture.Show();
            }
            else
            {
                MessageBox.Show("No existe un fixture generado.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string nombreMod = competenciaVerComp._modalidad._nombreMod;
            string estado = competenciaVerComp._estado;
            if (competenciaVerComp._tablaPosiciones != null && nombreMod == "SISTEMA DE LIGA" && (estado == "EN DISPUTA" || estado == "FINALIZADA"))
            {
                string formPunt = competenciaVerComp._modalidad._formaPuntuacion._nombreForma;
                if (formPunt == "RESULTADO FINAL" || formPunt == "SETS")
                {
                    // Se llama a la interfaz ver tabla de posiciones sin goles.
                    this.Close();
                    Interfaces.mostrarTablaSG mtSG = new Interfaces.mostrarTablaSG();
                    mtSG.MdiParent = Interfaces.principal.ActiveForm;
                    mtSG.competenciaSG = this.competenciaVerComp;
                    mtSG.Show();
                }
                else
                {
                    this.Close();
                    // Se llama a la interfaz ver tabla de posiciones con goles.
                    Interfases.mostrarTablaCG mtCG = new Interfases.mostrarTablaCG();
                    mtCG.MdiParent = Interfaces.principal.ActiveForm;
                    mtCG.competenciaCG = this.competenciaVerComp;
                    mtCG.Show();
                }
            }
            else
            {
                MessageBox.Show("No existe tabla de posiciones para esta competencia.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
