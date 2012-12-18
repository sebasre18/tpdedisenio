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
    public partial class listarParticipantes : Form
    {
        public Clases_de_entidad.CompetenciaDeportiva competenciaActual = new Clases_de_entidad.CompetenciaDeportiva();
        public Clases_de_entidad.Participante nuevoParticipanteLP = new Clases_de_entidad.Participante();
        public int fila = 0;
        
        public listarParticipantes()
        {
            InitializeComponent();
        }

        private void listarParticipantes_Load(object sender, EventArgs e)
        {
            // Muestra el nombre de la competencia en el label.
            lNombreCompetencia.Text = competenciaActual._nombre;

            /* Como solo se debe implementar las funcionalidades basicas no se tiene en cuenta que los participantes ya esten cargados con anterioridad.
               Se asume que al entrar a esta interfaz no hay participantes cargados.*/
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            altaParticipante ap = new altaParticipante();
            ap.MdiParent = principal.ActiveForm;
            ap.nuevoParticipanteAP = nuevoParticipanteLP; // public Clases_de_entidad.Participante nuevoParticipanteLP = new Clases_de_entidad.Participante(); (en altaParticipante)
            ap.Show();
            this.nuevoParticipanteLP = ap.nuevoParticipanteAP;
            // Mostrar en el datagriev el participante que se va agregando.
            dgvParticipantes.Rows.Add();
            dgvParticipantes[0, fila].Value = nuevoParticipanteLP._nombre;
            dgvParticipantes[1, fila].Value = nuevoParticipanteLP._email;
            fila = fila++;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no está desarrollada aún.");

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
