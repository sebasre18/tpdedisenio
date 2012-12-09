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
    public partial class verCompetencia : Form
    {
        public verCompetencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void verCompetencia_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            generarFixture genFixture;
            this.Close();
            genFixture = new generarFixture();
            genFixture.MdiParent = principal.ActiveForm;
            genFixture.WindowState = FormWindowState.Maximized;
            //genFixture.competenciaGenFix = competenciaVerComp;
            genFixture.Show();
        }
    }
}
