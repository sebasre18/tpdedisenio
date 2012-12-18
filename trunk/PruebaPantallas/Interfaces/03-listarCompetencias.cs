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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se cargan todas las competencias que existen.
            competenciasLC = gestorC.buscarCompetencias(usuarioLogueadoLC);
            int fila = 0;
            foreach (Clases_de_entidad.CompetenciaDeportiva unaCompetencia in competenciasLC)
            {
                dgvCompetencia.Rows.Add();
                dgvCompetencia[0, fila].Value = unaCompetencia._nombre;
                dgvCompetencia[1, fila].Value = unaCompetencia._deporte;
                dgvCompetencia[2, fila].Value = unaCompetencia._modalidad;
                dgvCompetencia[3, fila].Value = unaCompetencia._estado;
                fila++;
            }

        }

        private void bVer_Click(object sender, EventArgs e)
        {
            int filaSeleccionada;
            //Comprueba que tenga una competencia seleccionada.
            if (dgvCompetencia.SelectedRows == null)
            {
                mensajeTipo2 error;
                error = new mensajeTipo2();
                error.MdiParent = principal.ActiveForm;
                error.WindowState = FormWindowState.Maximized;
                error.error2 = "Debe seleccionar una competencia.";
                error.Show();
            }
            else 
            {
                // Abre la interfaz Ver Competencia, pasandole como parametro la competencia seleccionada.
                filaSeleccionada = Convert.ToInt32(dgvCompetencia.CurrentRow.Index);
                foreach (Clases_de_entidad.CompetenciaDeportiva unaCompetencia in competenciasLC)
                {
                    if (unaCompetencia._nombre == Convert.ToString(dgvCompetencia[0, filaSeleccionada].Value))
                    {
                        competenciaLC = unaCompetencia;
                        verCompetencia vc = new verCompetencia();
                        vc.MdiParent = principal.ActiveForm;
                        vc.WindowState = FormWindowState.Maximized;
                        vc.competenciaVerComp = competenciaLC;
                        vc.Show();
                    }
                        
                }
                
            }
            
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            altaCompetencia ac = new altaCompetencia();
            ac.MdiParent = principal.ActiveForm;
            ac.WindowState = FormWindowState.Maximized;
            ac.Show();
            this.Close();
        }

        
    }
}
