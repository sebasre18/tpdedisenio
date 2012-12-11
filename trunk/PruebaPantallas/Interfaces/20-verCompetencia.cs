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
        int cantDep, i=0, rondaActual, nR=0, bandera=0;
        string cadena;

        public verCompetencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void verCompetencia_Load(object sender, EventArgs e)
        {
            //Asigna los labels de la pantalla
            cantDep = competenciaVerComp._deportes.Count;
            labelEstadoComp.Text = competenciaVerComp._estado;
            labelModComp.Text = competenciaVerComp._modalidad._nombreMod;
            labelNombreComp.Text = competenciaVerComp._nombre;
            while (i < cantDep)
            {
                labelDeporteComp.Text = competenciaVerComp._deportes[i]._nombre+" ";
                i++;
            }
            
            //Completa los listBox
            foreach (Clases_de_entidad.Participante participante in competenciaVerComp._participantes)
            {
                listBoxParticipantes.Items.Add(participante._nombre);
            }

            foreach (Clases_de_entidad.Ronda ronda in competenciaVerComp._fixture._rondas)
            {
                nR = ronda._nro_ronda;
                foreach (Clases_de_entidad.Partido part in competenciaVerComp._fixture._rondas[nR]._partidos)
                {
                    if (part._resultado == null)
                    {
                        rondaActual = nR;
                        break;
                    }
                }
            }

            foreach (Clases_de_entidad.Partido partido in competenciaVerComp._fixture._rondas[rondaActual + 1]._partidos)
            {
                cadena = partido._participantes[0]._nombre + " - " + partido._participantes[1]._nombre;
                listBoxProxEncuentros.Items.Add(cadena);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            generarFixture genFixture;
            this.Close();
            genFixture = new generarFixture();
            genFixture.MdiParent = principal.ActiveForm;
            genFixture.WindowState = FormWindowState.Maximized;
            //genFixture.competenciaGenFix = competenciaVerComp;
            genFixture.Show();
        }

        private void buttonVerFixture_Click_1(object sender, EventArgs e)
        {
            
            //Comprovar que exista el fixture
            if (competenciaVerComp._fixture != null)
            {
                //Llamada a la nueva interfaz.
                mostrarFixtureSRG mostrarFixture;
                this.Close();
                mostrarFixture = new mostrarFixtureSRG();
                mostrarFixture.MdiParent = principal.ActiveForm;
                mostrarFixture.WindowState = FormWindowState.Maximized;
                mostrarFixture.competenciaVerFix = competenciaVerComp;
                mostrarFixture.Show();
            }
            else
            {
                mensajeTipo2 error;
                this.Close();
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "No existe un fixture generado.";
                error.Show();
            }
        }

    }
        
}
