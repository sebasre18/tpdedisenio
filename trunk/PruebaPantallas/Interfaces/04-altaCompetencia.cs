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
        public static List<Clases_de_entidad.LugarDeRealizacion> lugaresAC = new List<Clases_de_entidad.LugarDeRealizacion>();
        public Clases_de_entidad.Usuario usuarioLogueadoAC = new Clases_de_entidad.Usuario();
        public List<Clases_de_entidad.Deporte> deportes = new List<Clases_de_entidad.Deporte>();
        public Clases_de_entidad.Deporte dep;
        public Clases_de_entidad.Deporte depAux;

        Clases_de_control.GestorCompetencia gestorC = new Clases_de_control.GestorCompetencia();
        Clases_de_control.GestorLugarRealizacion gestorL = new Clases_de_control.GestorLugarRealizacion();

        public altaCompetencia()
        {
            InitializeComponent();
        }

        private void altaCompetencia_Load(object sender, EventArgs e)
        {
            List<Clases_de_entidad.Modalidad> modalidades = new List<Clases_de_entidad.Modalidad>();
            List<Clases_de_entidad.FormaPuntuacion> formasDePuntuacion = new List<Clases_de_entidad.FormaPuntuacion>();
            
            modalidades = gestorC.buscarModalidades();
            formasDePuntuacion = gestorC.buscarFormasDePuntuacion();
            deportes = gestorC.buscarDeportes();

            cbDeporte.Items.Add("");
            cbModalidad.Items.Add("");
            cbFormaPuntuacion.Items.Add("");

            foreach (Clases_de_entidad.Deporte unDeporte in deportes)
            {
                cbDeporte.Items.Add(unDeporte._nombre);
            }
            foreach (Clases_de_entidad.Modalidad unaModalidad in modalidades)
            {
                cbModalidad.Items.Add(unaModalidad._nombreMod);
            }
            foreach (Clases_de_entidad.FormaPuntuacion unaforma in formasDePuntuacion)
            {
                cbFormaPuntuacion.Items.Add(unaforma._nombreForma);
            }
            cbMaxSet.Items.Add("");  cbMaxSet.Items.Add(3); cbMaxSet.Items.Add(5); cbMaxSet.Items.Add(7); cbMaxSet.Items.Add(9);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int error = 0;
            error = validarCamposNulos();

            if (error == 1)
            {
                MessageBox.Show("Asegurese que ningun campo sea nulo"," ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
            }
            else if (cbModalidad.Text == "SISTEMA DE LIGA" && Convert.ToInt32(tbPtosGanado.Text) < Convert.ToInt32(tbPtosPresentarse.Text))
            {
                MessageBox.Show("La cantidad de puntos por partido ganado es menor que la cantidad de puntos por partido empatado"," ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Focus();
            }
            else
            {
                if (gestorC.compararNombre(tbNombre.Text))
                {
                    MessageBox.Show("El nombre ya existe.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dep = deporteSeleccionado(cbDeporte.Text, deportes);

                    // Se crea la forma de puntuacion con los datos ingresados por el usuario.
                    Clases_de_entidad.FormaPuntuacion formaDePuntuacion = new Clases_de_entidad.FormaPuntuacion();
                    formaDePuntuacion._nombreForma = cbFormaPuntuacion.Text;
                    if (cbMaxSet.Enabled == true)
                        formaDePuntuacion._cantidadSet = Convert.ToInt16(cbMaxSet.Text);
                    if (tbNoPresentarse.Enabled == true)
                        formaDePuntuacion._tantosAusencia = Convert.ToInt16(tbNoPresentarse.Text);

                    // Se crea la modalidad con los datos ingresados por el usuario.
                    Clases_de_entidad.Modalidad modalidad = new Clases_de_entidad.Modalidad();
                    modalidad._nombreMod = cbModalidad.Text;
                    if (tbPtosGanado.Enabled == true)
                        modalidad._ptosPG = Convert.ToInt16(tbPtosGanado.Text);
                    modalidad._empate = cbEmpate.Checked;
                    if (tbPtosEmpatado.Enabled == true)
                        modalidad._ptosEmpate = Convert.ToInt16(tbPtosEmpatado.Text);
                    if (tbPtosPresentarse.Enabled == true)
                        modalidad._ptosPresentarse = Convert.ToInt16(tbPtosPresentarse.Text);
                    modalidad._formaPuntuacion = formaDePuntuacion;

                    Clases_de_entidad.CompetenciaDeportiva nuevaCompetencia = new Clases_de_entidad.CompetenciaDeportiva("CREADA", Convert.ToString(tbNombre.Text), Convert.ToString(rtbReglamento.Text), dep, lugaresAC, modalidad, usuarioLogueadoAC);
                    /*mensajeTipo1 msj = new mensajeTipo1();
                    msj.mensaje = "La competencia se creo satisfactoriamente.";
                    msj.Show();*/
                    MessageBox.Show("La competencia se creo satisfactoriamente.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Se guarda la competencia en la Base de Datos.
                    Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
                    nuevaCompetencia._id_competencia = competenciaABD.setCompetencia(nuevaCompetencia);


                    // Abre la interfaz listar participantes de la competencia.
                    listarParticipantes listarP = new listarParticipantes();
                    this.Close();
                    listarP.MdiParent = Interfaces.principal.ActiveForm;
                    listarParticipantes.competenciaActual = nuevaCompetencia;
                    listarP.Show();
                    
                }
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                    //Enfoco en el primer TextBox
                    this.tbNombre.Focus();
                }
            }
            cbDeporte.SelectedIndex = 0;
            cbModalidad.SelectedIndex = 0;
            cbFormaPuntuacion.SelectedIndex = 0;
            cbMaxSet.SelectedIndex = 0;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLugares_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dep == null)
                MessageBox.Show("Debe seleccionar un deporte.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //busca los lugares por primera vez o cuando cambia el deporte seleccionado
                if (lugaresAC.Count == 0)
                    lugaresAC = gestorL.buscarLugares(dep._nombre, usuarioLogueadoAC._email);
                else
                {
                    if (dispCargadas() == lugaresAC.Count)
                        lugaresAC = gestorL.buscarLugares(dep._nombre, usuarioLogueadoAC._email);
                }

                //Abre la interfaz para cargar la disponibilidad de los lugares, pasandole como parametro una lista con los lugares de realizacion.
                cargarLugar cl = new cargarLugar();
                //cl.MdiParent = Interfaces.principal.ActiveForm;
                cl.lugaresCL = lugaresAC;
                cl.Show();
            }
        }

        ////////////////////////////////Metodos auxiliares////////////////////////////////////

        private Clases_de_entidad.Deporte deporteSeleccionado(string textoDeporte, List<Clases_de_entidad.Deporte> coleccionDeportes)
        {
            /*Recibe el texto que indica que deporte se selecciono en el ComboBox Deporte y la coleccion de deportes traida de la Base de Datos,
            y devuelve el objeto deporte con el nombre seleccionado.*/
            foreach (Clases_de_entidad.Deporte unDeporte in coleccionDeportes)
            {
                if (unDeporte._nombre == textoDeporte)
                {
                    return unDeporte;
                }
            }
            return null;
        }

        private int validarCamposNulos()
        {
            if (tbNombre.Text == "")
                return 1;
            if (cbDeporte.Text == "")
                return 1;
            if (cbModalidad.Text == "")
                return 1;
            if (tbPtosGanado.Enabled == true && tbPtosGanado.Text == "")
                return 1;
            if (tbPtosEmpatado.Enabled == true && tbPtosEmpatado.Text == "")
                return 1;
            if (tbPtosPresentarse.Enabled == true && tbPtosPresentarse.Text == "")
                return 1;
            if (cbFormaPuntuacion.Text == "")
                return 1;
            if (cbMaxSet.Enabled == true && cbMaxSet.Text == "")
                return 1;
            if (tbNoPresentarse.Enabled == true && tbNoPresentarse.Text == "")
                return 1;
            if (dispCargadas() == lugaresAC.Count)
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
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
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

        private void cbModalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFormaPuntuacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMaxSet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbEmpate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmpate.Checked)
            {
                tbPtosEmpatado.Enabled = true;
                lPtosEmpatado.Enabled = true;
            }
            else
            {
                tbPtosEmpatado.Text = null;
                
                tbPtosEmpatado.Enabled = false;
                lPtosEmpatado.Enabled = false;
            }
        }

        private void cbModalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbModalidad.Text == "SISTEMA DE LIGA")
            {
                tbPtosGanado.Enabled = true;
                cbEmpate.Enabled = true;
                tbPtosPresentarse.Enabled = true;

                lPtosGanado.Enabled = true;
                lPtosPresentarse.Enabled = true;
            }
            else
            {
                tbPtosGanado.Text = null;
                cbEmpate.Checked = false;
                tbPtosPresentarse.Text = null;
                tbPtosEmpatado.Text = null;

                cbEmpate.Enabled = false;
                lPtosEmpatado.Enabled = false;
                tbPtosEmpatado.Enabled = false;
                tbPtosGanado.Enabled = false;
                tbPtosPresentarse.Enabled = false;
                lPtosGanado.Enabled = false;
                lPtosPresentarse.Enabled = false;
            }
        }

        private void cbFormaPuntuacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFormaPuntuacion.Text == "SETS")
            {
                cbMaxSet.Enabled = true;
                lMaxSet.Enabled = true;
            }
            else
            {
                cbMaxSet.SelectedIndex = 0;
                
                cbMaxSet.Enabled = false;
                lMaxSet.Enabled = false;
            }
            if (cbFormaPuntuacion.Text == "PUNTUACION")
            {
                tbNoPresentarse.Enabled = true;
                lNoPresentarse.Enabled = true;
                cbMaxSet.SelectedIndex = 0;
            }
            else
            {
                cbMaxSet.SelectedIndex = 0;
                tbNoPresentarse.Text = null;
                
                tbNoPresentarse.Enabled = false;
                lNoPresentarse.Enabled = false;
            }
        }

        private void cbDeporte_SelectedValueChanged(object sender, EventArgs e)
        {
            dep = new Clases_de_entidad.Deporte();
            dep = deporteSeleccionado(cbDeporte.Text, deportes);
            lugaresAC = new List<Clases_de_entidad.LugarDeRealizacion>();
        }

        private int dispCargadas()
        {
            int cantNulas = 0;
            foreach (var unLugar in lugaresAC)
            {
                if (unLugar._disponibilidad._turnosPorFecha == 0)
                    cantNulas++;
            }
            return cantNulas;
        }

    }
}
