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
        public List<Clases_de_entidad.LugarDeRealizacion> lugares = new List<Clases_de_entidad.LugarDeRealizacion>();

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
            foreach (Clases_de_entidad.LugarDeRealizacion unLugar in lugares)
            {
                dgvLugares.Rows.Add();
                dgvLugares[0, fila].Value = unLugar._nombre;
                fila++;
            }

            
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            List<Clases_de_entidad.LugarDeRealizacion> auxLugares = new List<Clases_de_entidad.LugarDeRealizacion>();
            foreach (Clases_de_entidad.LugarDeRealizacion unLugar in lugares)
            {
                if (unLugar._nombre == Convert.ToString(dgvLugares[0, fila].Value))
                {
                    //unLugar._disponibilidad = Convert.ToInt32(dgvLugares[1, fila].Value);
                    auxLugares.Add(unLugar);
                }
                fila++;
            }
            
            // Guardar auxLugares en la BD.

            this.Close();
        }

        
    }
}
