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
        public List<Clases_de_entidad.LugarDeRealizacion> lugaresAC = new List<Clases_de_entidad.LugarDeRealizacion>();
        public Clases_de_entidad.Usuario usuarioLogueadoAC = new Clases_de_entidad.Usuario();
        
        Clases_de_control.GestorCompetencia gestorC = new Clases_de_control.GestorCompetencia();
        Clases_de_control.GestorLugarRealizacion gestorL = new Clases_de_control.GestorLugarRealizacion();
        
        public altaCompetencia()
        {
            InitializeComponent();
        }

        private void altaCompetencia_Load(object sender, EventArgs e)
        {
           
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
            List<Clases_de_entidad.Deporte> deportes = gestorC.buscarDeportes();
            error = validarCamposNulos();
            Clases_de_entidad.Deporte dep = deporteSeleccionado(cbDeporte.Text, deportes);

            if (error == 1)
            {
                MessageBox.Show("Asegurese que ningun campo sea nulo");
                tbNombre.Focus();
            }
            else
            {
                short existe = gestorC.compararNombre(tbNombre.Text);
                if (existe == 1)
                {
                    MessageBox.Show("El nombre ya existe.");
                    tbNombre.Focus();
                }
                else
                {
                    Clases_de_entidad.FormaPuntuacion formaDePuntuacion = new Clases_de_entidad.FormaPuntuacion(cbFormaPuntuacion.Text, Convert.ToInt16(cbMaxSet.Text), Convert.ToInt16(tbNoPresentarse.Text));
                    Clases_de_entidad.Modalidad modalidad = new Clases_de_entidad.Modalidad(cbModalidad.Text, Convert.ToInt16(tbPtosGanado.Text), cbEmpate.Checked, Convert.ToInt16(tbPtosEmpatado.Text), Convert.ToInt16(tbPtosPresentarse.Text), formaDePuntuacion);
                    Clases_de_entidad.CompetenciaDeportiva nuevaCompetencia = gestorC.crearCompetencia("Creada", tbNombre.Text, rtbReglamento.Text, dep, lugaresAC, modalidad, usuarioLogueadoAC);
                    // TERMINAR DE MANDAR PARAMETROS.
                    MessageBox.Show("La competencia se creo satisfactoriamente.");
                    // GUARDAR COMPETENCIA EN BD.
                    // Abre la interfaz listar participantes de la competencia.
                    listarParticipantes listarP = new listarParticipantes();
                    listarP.MdiParent = principal.ActiveForm;
                    listarP.competenciaActual = nuevaCompetencia;
                    listarP.Show();
                    this.Close();
                }
                
            }

        }

        private void linkLugares_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Clases_de_entidad.Deporte> deportes = gestorC.buscarDeportes();
            List<Clases_de_entidad.Modalidad> modalidades = gestorC.buscarModalidades();
            Clases_de_entidad.Deporte dep = deporteSeleccionado(cbDeporte.Text, deportes);
            List<Clases_de_entidad.LugarDeRealizacion> coleccionLugares = gestorL.buscarLugares(dep, usuarioLogueadoAC._email);
            
            //Abre la interfaz para cargar la disponibilidad de los lugares, pasandole como parametro una lista con los lugares de realizacion.
            cargarLugar cl = new cargarLugar();
            cl.MdiParent = principal.ActiveForm;
            cl.WindowState = FormWindowState.Maximized;
            cl.lugaresCL = coleccionLugares;
            cl.Show();
            this.lugaresAC = cl.lugaresAux;
            //PROBAR SI LUGARES ES LA LISTA MODIFICADA.
            
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
            /*Recibe el texto que indica que deporte se selecciono en el ComboBox Deporte y la coleccion de deportes traida de la Base de Datos,
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
            if(cbEmpate.Checked)
            {
                tbPtosEmpatado.Enabled = true;
            }
            else
            {
                tbPtosEmpatado.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbModalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbModalidad.Text == "SISTEMA DE LIGA")
            {
                tbPtosGanado.Enabled = true;
                cbEmpate.Enabled = true;
                tbPtosPresentarse.Enabled = true;
            }
        }

        private void cbFormaPuntuacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbFormaPuntuacion.Text == "SET")
                cbMaxSet.Enabled = true;
            if (cbFormaPuntuacion.Text == "PUNTUACION")
                tbNoPresentarse.Enabled = true;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";

                    //Enfoco en el primer TextBox

                    this.tbNombre.Focus();
                }
            }
        }

        

    }
}
