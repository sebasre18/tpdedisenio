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
            /*
            competenciaGenFix._id_competencia = 3;
            competenciaGenFix._nombre = "COMPETENCIA DE PRUEBA";
            competenciaGenFix._estado = "CREADA";
            Clases_de_entidad.Modalidad mod = new Clases_de_entidad.Modalidad();
            mod._nombreMod = "LIGA";
            competenciaGenFix._modalidad = mod;
            */

            //se completa la interfaz con el nombre y estado de la competencia
            labelNombreComp.Text = competenciaGenFix._nombre;
            labelEstadoComp.Text = competenciaGenFix._estado;
            
            /*
            competenciaGenFix._participantes = new List<Clases_de_entidad.Participante>();
            for (short i = 1; i <=5; i++)
            {
                Clases_de_entidad.Participante participante = new Clases_de_entidad.Participante();
                participante._nombre = "PARTICIPANTE" + i;
                participante._id_participante = i;
                competenciaGenFix._participantes.Add(participante);
            }
            */
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

                //se busca la lista de participantes de la competencia
                List<Clases_de_entidad.Participante> listaParticipantes = new List<Clases_de_entidad.Participante>();
                listaParticipantes = competenciaGenFix._participantes;
                Clases_de_control.GestorFixture gFixture = new Clases_de_control.GestorFixture();

                string caseSwitch = mod._nombreMod;
                switch (caseSwitch)
                {
                    case "LIGA":
                        Clases_ABD.ABDfixture fixtureABD = new Clases_ABD.ABDfixture();
                        if (competenciaGenFix._fixture != null) //si existe un fixture en la competencia se elimina de la BD
                        {
                            fixtureABD.deleteFixture(competenciaGenFix);
                            MessageBox.Show("Se esta borrando el fixture anterior de la competencia.");
                        }
                        //Llamamos al metodo dentro del gestor para generar el fixture
                        competenciaGenFix._fixture = gFixture.generarFixtureLiga(listaParticipantes);
                        competenciaGenFix._estado = "PLANIFICADA";

                        //Se guarda el nuevo fixture en la BD
                        fixtureABD.guardarFixture(competenciaGenFix);
                        this.Close();
                        MessageBox.Show("El fixture se genero exitosamente.");
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
