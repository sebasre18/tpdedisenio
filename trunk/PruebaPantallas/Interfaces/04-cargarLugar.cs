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
    public partial class cargarLugar : Form
    {
        public List<Clases_de_entidad.LugarDeRealizacion> lugaresCL = new List<Clases_de_entidad.LugarDeRealizacion>();
        public List<Clases_de_entidad.LugarDeRealizacion> lugaresAux = new List<Clases_de_entidad.LugarDeRealizacion>();
            
        /* CASO DE PRUEBA
        Clases_de_entidad.LugarDeRealizacion lugar1 = new Clases_de_entidad.LugarDeRealizacion("LA CANCHA DE LA LORA");
        Clases_de_entidad.LugarDeRealizacion lugar2 = new Clases_de_entidad.LugarDeRealizacion("EL UÑAZO");
        public List<Clases_de_entidad.LugarDeRealizacion> lugares = new List<Clases_de_entidad.LugarDeRealizacion>(); */
        
        
        public cargarLugar()
        {
            InitializeComponent();
        }

        private void cargarLugar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            /*lugares.Add(lugar1);
            lugares.Add(lugar2);*/

            //Inserta los Lugares de Realizacion en el DataGriv.
            int fila = 0;
            foreach (Clases_de_entidad.LugarDeRealizacion unLugar in lugaresCL)
            {
                dgvLugares.Rows.Add();
                dgvLugares[0, fila].Value = unLugar._nombre;
                fila++;
            }
            foreach (Clases_de_entidad.LugarDeRealizacion unLugar in lugaresCL)
            {
                if (unLugar._nombre == Convert.ToString(dgvLugares[0, fila].Value))
                {
                    dgvLugares[1, fila].Value = unLugar._disponibilidad._turnosPorFecha;
                }
                fila++;
            }

            
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            Clases_de_entidad.Disponibilidad disponibilidadAux;
            foreach (Clases_de_entidad.LugarDeRealizacion unLugar in lugaresCL)
            {
                // PROBAR SI LA LISTA QUE RETORNA A ALTACOMPETENCIA ES LA MODIFICADA.
                if (unLugar._nombre == Convert.ToString(dgvLugares[0, fila].Value))
                {
                    disponibilidadAux = new Clases_de_entidad.Disponibilidad(Convert.ToInt16(dgvLugares[1, fila].Value));
                    unLugar._disponibilidad = disponibilidadAux;
                    lugaresAux.Add(unLugar);
                }
                fila++;
            }
            this.Close();
        }

        private void dgvLugares_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            if (dgvLugares.CurrentCell.ColumnIndex == 1)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvLugares_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvLugares_KeyPress);
                }
            }
        }

        private void dgvLugares_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Restringe el ingreso de datos a numeros.
            if (dgvLugares.CurrentCell.ColumnIndex == 1)
            {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        
    }
}
