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
    public partial class listarCompetencias : Form
    {
        public List<Clases_de_entidad.CompetenciaDeportiva> competenciasLC = new List<Clases_de_entidad.CompetenciaDeportiva>();
        public Clases_de_entidad.CompetenciaDeportiva competenciaLC = new Clases_de_entidad.CompetenciaDeportiva();
        public Clases_de_entidad.Usuario usuarioLogueadoLC = new Clases_de_entidad.Usuario();

        Clases_de_control.GestorCompetencia gestorC = new Clases_de_control.GestorCompetencia();
        
        public listarCompetencias()
        {
            InitializeComponent();
        }       

        private void bVer_Click(object sender, EventArgs e)
        {
            int filaSeleccionada=0;
            //Comprueba que tenga una competencia seleccionada.
            if (dgvCompetencia.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una competencia", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                // Trae todos los datos completos de la competencia seleccionada por el usuario.
                filaSeleccionada = Convert.ToInt32(dgvCompetencia.CurrentRow.Index);
                foreach (Clases_de_entidad.CompetenciaDeportiva unaCompetencia in competenciasLC)
                {
                    if (unaCompetencia._nombre == Convert.ToString(dgvCompetencia[0, filaSeleccionada].Value))
                    {
                        competenciaLC = gestorC.buscarUnaCompetencia(unaCompetencia._id_competencia);
                    }
                        
                }
                // Abre la interfaz Ver Competencia, pasandole como parametro la competencia seleccionada.
                verCompetencia vc = new verCompetencia();                
                vc.MdiParent = Interfaces.principal.ActiveForm;
                vc.competenciaVerComp = competenciaLC;
                vc.Show();
                this.Close();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            altaCompetencia ac = new altaCompetencia();
            ac.MdiParent = Interfaces.principal.ActiveForm;
            ac.usuarioLogueadoAC = usuarioLogueadoLC;
            ac.Show();
            this.Close();
        }

        private void listarCompetencias_Load_1(object sender, EventArgs e)
        {
            Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
            usuarioLogueadoLC._email = "EMAIL@HOTMAIL.COM";

            // Se cargan todas las competencias que existen.
            competenciasLC = gestorC.buscarCompetencias(usuarioLogueadoLC);
            int fila = 0;
            foreach (Clases_de_entidad.CompetenciaDeportiva unaCompetencia in competenciasLC)
            {
                dgvCompetencia.Rows.Add();
                dgvCompetencia[0, fila].Value = unaCompetencia._nombre;
                dgvCompetencia[1, fila].Value = unaCompetencia._deporte._nombre;
                dgvCompetencia[2, fila].Value = unaCompetencia._modalidad._nombreMod;
                dgvCompetencia[3, fila].Value = unaCompetencia._estado;
                fila++;
            }
        }

        
    }
}
