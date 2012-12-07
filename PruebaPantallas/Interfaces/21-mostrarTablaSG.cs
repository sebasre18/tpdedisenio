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
        public mostrarTablaSG()
        {
            InitializeComponent();
        }

        private void mostrarTablaSG_Load(object sender, EventArgs e, Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            labelCompetencia.Text = competencia.nombre;

            Clases_de_control.GestorCompetencia gestorComp = new Clases_de_control.GestorCompetencia();
            Clases_de_entidad.TablaPosiciones tablaPos = gestorComp.verTabla(competencia);

            int fila = 0;
            foreach (Clases_de_entidad.TablaPosiciones.renglones)
            {
                DataGridView2.Rows.Add();
                DataGridView2[1, fila].Value = ev._fecha_inicio;
                DataGridView2[2, fila].Value = ev._fecha_fin;
                DataGridView2[3, fila].Value = ev._cod_evaluacion; //columna oculta para determinar seleccionadas
                fila++;
            }


        }
    }
}
