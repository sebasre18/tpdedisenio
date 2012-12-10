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
    public partial class altaCompetencia : Form
    {
        public altaCompetencia()
        {
            InitializeComponent();
        }

        private void altaCompetencia_Load(object sender, EventArgs e)
        {
            CargarPantalla();
        }

        private void Cargar_Pantalla()
        {
            //Todo lo del load.
        }

        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void cbDeporte_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void cbModalidad_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbPtosGanado_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbPtosEmpatado_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbPtosPresentarse_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void cbEmpate_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void cbFormaPuntuacion_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbMaxSet_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void tbNoPresentarse_KeyDown(object sender, KeyEventArgs e)
        {
            simulaTab(e);
        }

        private void simulaTab(KeyEventArgs e)
        {
            //El Enter simula el Tab (pasa al siguiente objeto)
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se ingresan solo caracteres alfanumericos.
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                //Cuando es false se escribe el caracter e.
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //Cuando es TRUE, no se escribe el caracter e. 
                e.Handled = true;
            }
        }

        private void tbPtosGanado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se ingresan solo enteros.
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbPtosEmpatado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se ingresan solo enteros.
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbPtosPresentarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se ingresan solo enteros.
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNoPresentarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        

       

     }
}
