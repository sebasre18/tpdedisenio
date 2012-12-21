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
    public partial class mensajeTipo2 : Form
    {
        public string mensaje;

        public mensajeTipo2()
        {
            InitializeComponent();
        }

        private void mensajeTipo2_Load(object sender, EventArgs e)
        {
            lError.ForeColor = Color.Red;
            lError.Text = mensaje;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


   }
}
