using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPdeDiseño.Interfases
{
    public partial class mostrarTablaCG : Form
    {

        public Clases_de_entidad.CompetenciaDeportiva competenciaCG = new Clases_de_entidad.CompetenciaDeportiva();
        
        public mostrarTablaCG()
        {
            InitializeComponent();
        }

        private void mostrarTablaCG_Load(object sender, EventArgs e)
        {
            labelCompetencia.Text = competenciaCG._nombre;

            // Se cargan los datos en la tabla de posiciones en orden descendente.
            int fila = 0;
            foreach (Clases_de_entidad.renglonTabla renglon in competenciaCG._tablaPosiciones._renglones)
            {
                dgvTablaCG.Rows.Add();
                dgvTablaCG[0, fila].Value = renglon._nombreParticipante;
                dgvTablaCG[1, fila].Value = renglon._pts;
                dgvTablaCG[2, fila].Value = renglon._pGanado;
                dgvTablaCG[3, fila].Value = renglon._pEmpatado;
                dgvTablaCG[4, fila].Value = renglon._pPerdido;
                dgvTablaCG[5, fila].Value = renglon._golesFavor;
                dgvTablaCG[6, fila].Value = renglon._golesContra;
                dgvTablaCG[7, fila].Value = renglon._diferencia;
                fila++;
            }
            this.dgvTablaCG.Sort(this.dgvTablaCG.Columns[1], ListSortDirection.Descending);
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            // Fijarse que se guarda en "exportar".. o si se exporta solo, o que mierda hacer esto.
            Clases_de_entidad.ExportarExcel exportar = new Clases_de_entidad.ExportarExcel(dgvTablaCG);
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dgvTablaCG, myPaintArgs);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            verCompetencia vc = new verCompetencia();
            vc.MdiParent = Interfaces.principal.ActiveForm;
            vc.competenciaVerComp = competenciaCG;
            vc.Show();
        }       
    }
}
