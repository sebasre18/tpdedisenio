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
    public partial class generarFixture : Form
    {
        public Clases_de_entidad.CompetenciaDeportiva competenciaGenFix = new Clases_de_entidad.CompetenciaDeportiva();
                        
        public generarFixture()
        {
            InitializeComponent();
        }

        private void generarFixture_Load(object sender, EventArgs e)
        {
            //competenciaGenFix._nombre = "COMPETENCIA DE PRUEBA";
            //competenciaGenFix._estado = "CREADA";
            //Clases_de_entidad.Modalidad mod = new Clases_de_entidad.Modalidad();
            //mod._nombreMod = "LIGA";
            //competenciaGenFix._modalidad = mod;

            //se completa la interfaz con el nombre y estado de la competencia
            labelNombreComp.Text = competenciaGenFix._nombre;
            labelEstadoComp.Text = competenciaGenFix._estado;

            /*
            competenciaGenFix._participantes = new List<Clases_de_entidad.Participante>();
            int i;
            for (i = 1; i < 20; i++)
            {
                Clases_de_entidad.Participante participante = new Clases_de_entidad.Participante();
                participante._nombre = "equipo" + i;
                competenciaGenFix._participantes.Add(participante);
            }*/
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if ((competenciaGenFix._estado == "EN DISPUTA") || (competenciaGenFix._estado == "FINALIZADA"))
                MessageBox.Show("No se puede volver a generar el fixture.");
            else
            {
                //se busca la modalidad
                Clases_de_entidad.Modalidad mod = new Clases_de_entidad.Modalidad();
                mod = competenciaGenFix._modalidad;

                string caseSwitch = mod._nombreMod;
                switch (caseSwitch)
                {
                    case "LIGA":
                        //se busca la lista de participantes de la competencia
                        List<Clases_de_entidad.Participante> listaParticipantes = new List<Clases_de_entidad.Participante>();
                        listaParticipantes = competenciaGenFix._participantes;

                        //se crea el fixture, el gestor y se llama a la funcion para generar el fixture.
                        Clases_de_entidad.Fixture fixture = new Clases_de_entidad.Fixture();
                        Clases_de_control.GestorFixture gFixture = new Clases_de_control.GestorFixture();
                        fixture = gFixture.generarFixtureLiga(listaParticipantes);
                        break;
                    case "ELIMINACION SIMPLE":
                        MessageBox.Show("La funcionalidad no esta implementada.");
                        break;
                    case "ELIMINACION DOBLE":
                        MessageBox.Show("La funcionalidad no esta implementada.");
                        break;
                }
            }
        }    

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
