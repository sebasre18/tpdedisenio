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

            //se completa la interfaz con el nombre y estado de la competencia
            labelNombreComp.Text = competenciaGenFix._nombre;
            labelEstadoComp.Text = competenciaGenFix._estado;
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if ((competenciaGenFix._estado == "EN DISPUTA") || (competenciaGenFix._estado == "FINALIZADA"))
                MessageBox.Show("No se puede volver a generar el fixture.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    case "SISTEMA DE LIGA":
                        Clases_ABD.ABDfixture fixtureABD = new Clases_ABD.ABDfixture();
                        if (competenciaGenFix._fixture != null) //si existe un fixture en la competencia se elimina de la BD
                        {
                            fixtureABD.deleteFixture(competenciaGenFix);
                            MessageBox.Show("Se esta borrando el fixture anterior de la competencia.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //Llamamos al metodo dentro del gestor para generar el fixture
                        competenciaGenFix._fixture = gFixture.generarFixtureLiga(listaParticipantes);
                        competenciaGenFix._estado = "PLANIFICADA";

                        //Se guarda el nuevo fixture en la BD
                        competenciaGenFix._fixture = fixtureABD.guardarFixture(competenciaGenFix);

                        //Genera la tabla de posiciones
                        Clases_de_control.GestorTabla gTabla = new Clases_de_control.GestorTabla();                        
                        competenciaGenFix._tablaPosiciones = gTabla.crearTabla(competenciaGenFix);

                        MessageBox.Show("El fixture se genero exitosamente.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        verCompetencia vc = new verCompetencia();
                        vc.MdiParent = Interfaces.principal.ActiveForm;
                        vc.competenciaVerComp = competenciaGenFix;
                        vc.Show();
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
            verCompetencia vc = new verCompetencia();
            vc.MdiParent = Interfaces.principal.ActiveForm;
            vc.competenciaVerComp = competenciaGenFix;
            vc.Show();
        }
    }
}
