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
        Clases_de_control.GestorUsuario gestorU = new Clases_de_control.GestorUsuario();
        Clases_de_entidad.Usuario unUsuario;
        Clases_de_control.GestorCompetencia gestorC = new Clases_de_control.GestorCompetencia();
        List<Clases_de_entidad.Deporte> deportes;
        List<Clases_de_entidad.Modalidad> modalidades;
        Clases_de_control.GestorLugarRealizacion gestorL = new Clases_de_control.GestorLugarRealizacion();
               
        public altaCompetencia()
        {
            InitializeComponent();
        }

        private void altaCompetencia_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarPantalla();
        }

        private void CargarPantalla()
        {
            
            //Seguir con el diagrama de secuencia.
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

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int error = 0;
            error = validarCamposNulos();

            if (error == 1)
            {
                MessageBox.Show("Asegurese que ningun campo sea nulo");
                tbNombre.Focus();
            }
            //else 
                // Comparar nombre en BD, etc.

        }

        private void linkLugares_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deportes = gestorC.buscarDeportes();
            modalidades = gestorC.buscarModalidades();
            unUsuario = gestorU.crearUsuario();
            Clases_de_entidad.Deporte dep = deporteSeleccionado(cbDeporte.Text, deportes);
            List<Clases_de_entidad.LugarDeRealizacion> coleccionLugares = gestorL.buscarLugares(dep, unUsuario._email);
            
            //Abre la interfaz para cargar la disponibilidad de los lugares, pasandole como parametro una lista con los lugares de realizacion.
            cargarLugar cl = new cargarLugar();
            cl.MdiParent = principal.ActiveForm;
            cl.WindowState = FormWindowState.Maximized;
            cl.lugares = coleccionLugares;
            cl.Show();


        }

        ////////////////////////////////Metodos auxiliares////////////////////////////////////

        private int validarCamposNulos()
        {
            if (tbNombre.Text == "")
                return 1;
            if (cbDeporte.Text == "")
                return 1;
            if (cbModalidad.Text == "")
                return 1;
            if (tbPtosGanado.Text == "")
                return 1;
            if (cbFormaPuntuacion.Text == "")
                return 1;
            if (cbMaxSet.Text == "")
                return 1;
            if (tbNoPresentarse.Text == "")
                return 1;
            return 0;
            //Falta validar la parte de permitir empate.

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

        private Clases_de_entidad.Deporte deporteSeleccionado(string textoDeporte, List<Clases_de_entidad.Deporte> coleccionDeportes)
        {
            /*Recibe el texto que indica que deporte se selecciono en el ComboBox Deporte y la coleccione de deportes traida de la Base de Datos,
            y devuelve el objeto deporte con el nombre seleccionado.*/
            foreach (Clases_de_entidad.Deporte unDeporte in coleccionDeportes)
            {
                if(unDeporte._nombre == textoDeporte)
                {
                    return unDeporte;
                }
            }
            return null;
        }

        private void cbEmpate_CheckedChanged(object sender, EventArgs e)
        {
            // FALTA HABILITAR OPCIONES CUANDO SE TILDA "PERMITIR EMPATE"
        }

        

    }
}
