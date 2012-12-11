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
        public List<Clases_de_entidad.LugarDeRealizacion> lugares = new List<Clases_de_entidad.LugarDeRealizacion>;
        
        public cargarLugar()
        {
            InitializeComponent();
        }

        private void cargarLugar_Load(object sender, EventArgs e)
        {

        }
    }
}
