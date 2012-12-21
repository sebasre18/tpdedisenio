using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPdeDiseño.Interfaces
{
    public partial class mostrarTablaSG : Form
    {
        public Clases_de_entidad.CompetenciaDeportiva competenciaSG = new Clases_de_entidad.CompetenciaDeportiva();
        
        public mostrarTablaSG()
        {
            InitializeComponent();
        }

        private void mostrarTablaSG_Load(object sender, EventArgs e)
        {
            labelCompetencia.Text = competenciaSG._nombre;
            
            // Se cargan los datos en la tabla de posiciones en orden descendente.
            int fila = 0;
            foreach (Clases_de_entidad.renglonTabla renglon in competenciaSG._tablaPosiciones._renglones)
            {
                dgvTablaSG.Rows.Add();
                dgvTablaSG[0, fila].Value = renglon._nombreParticipante;
                dgvTablaSG[1, fila].Value = renglon._pts;
                dgvTablaSG[2, fila].Value = renglon._pGanado;
                dgvTablaSG[3, fila].Value = renglon._pEmpatado;
                dgvTablaSG[4, fila].Value = renglon._pPerdido;
                fila++;
            }
            this.dgvTablaSG.Sort(this.dgvTablaSG.Columns[1], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fijarse que se guarda en "exportar".. o si se exporta solo, o que mierda hacer esto.
            Clases_de_entidad.ExportarExcel exportar = new Clases_de_entidad.ExportarExcel(dgvTablaSG);
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dgvTablaSG, myPaintArgs);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            verCompetencia vc = new verCompetencia();
            vc.MdiParent = principal.ActiveForm;
            vc.competenciaVerComp = competenciaSG;
            vc.Show();
        }
    }
}
