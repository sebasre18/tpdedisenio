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
    public partial class principal : Form
    {
        public Clases_de_entidad.Usuario usuarioLogueadoP = new Clases_de_entidad.Usuario();
        
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autentificarUsuario au = new autentificarUsuario();
            au.MdiParent = principal.ActiveForm;
            au.WindowState = FormWindowState.Maximized;
            au.Show();
            this.usuarioLogueado = au.usuarioNuevo;
            tsmiIniciar.Enabled = false;
            tsmiCerrar.Enabled = true;
            tsmiModificar.Enabled = true;
            tsmiAltaCompetencia.Enabled = true;
            tsmiListarCompetencias.Enabled = true;
            tsmiListarLugares.Enabled = true;
        }

        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            // Borra los datos del usuario loguado.
            Clases_de_entidad.Usuario usuarioDeslogueado = new Clases_de_entidad.Usuario();
            usuarioLogueado = usuarioDeslogueado;
            
            tsmiIniciar.Enabled = true;
            tsmiCerrar.Enabled = false;
            tsmiModificar.Enabled = false;
            tsmiAltaCompetencia.Enabled = false;
            tsmiListarCompetencias.Enabled = false;
            tsmiListarLugares.Enabled = false;
        }

        private void tsmiModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");

        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiListarLugares_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");

        }

        private void tsmiListarTodas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");

        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felices fiestas!!!. Andres, Nair, Sebastián, Hernán.");
        }

        private void tsmiAltaCompetencia_Click(object sender, EventArgs e)
        {
            altaCompetencia ac = new altaCompetencia();
            ac.MdiParent = principal.ActiveForm;
            ac.WindowState = FormWindowState.Maximized;
            ac.usuarioLogueadoAC = this.usuarioLogueadoP;
            ac.Show();
        }

        private void tsmiListarCompetencias_Click(object sender, EventArgs e)
        {
            listarCompetencias lc = new listarCompetencias();
            lc.MdiParent = principal.ActiveForm;
            lc.WindowState = FormWindowState.Maximized;
            lc.usuarioLogueadoLC = this.usuarioLogueadoP;
            lc.Show();
        }

        ////////////////////////////////////// Metodos auxiliares ////////////////////////////////////////
        
    }
}
