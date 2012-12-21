namespace TPdeDiseño
{
    partial class altaCompetencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDeporte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.lPtosGanado = new System.Windows.Forms.Label();
            this.tbPtosGanado = new System.Windows.Forms.TextBox();
            this.cbEmpate = new System.Windows.Forms.CheckBox();
            this.lPtosEmpatado = new System.Windows.Forms.Label();
            this.tbPtosEmpatado = new System.Windows.Forms.TextBox();
            this.lPtosPresentarse = new System.Windows.Forms.Label();
            this.tbPtosPresentarse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFormaPuntuacion = new System.Windows.Forms.ComboBox();
            this.lMaxSet = new System.Windows.Forms.Label();
            this.lNoPresentarse = new System.Windows.Forms.Label();
            this.tbNoPresentarse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.rtbReglamento = new System.Windows.Forms.RichTextBox();
            this.linkLugares = new System.Windows.Forms.LinkLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbMaxSet = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(44, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(137, 13);
            this.labelNombre.TabIndex = 50;
            this.labelNombre.Text = "Nombre de la competencia:";
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(187, 22);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(360, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyDown);
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Deporte:";
            // 
            // cbDeporte
            // 
            this.cbDeporte.FormattingEnabled = true;
            this.cbDeporte.Location = new System.Drawing.Point(98, 60);
            this.cbDeporte.Name = "cbDeporte";
            this.cbDeporte.Size = new System.Drawing.Size(83, 21);
            this.cbDeporte.TabIndex = 2;
            this.cbDeporte.SelectedValueChanged += new System.EventHandler(this.cbDeporte_SelectedValueChanged);
            this.cbDeporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDeporte_KeyDown);
            this.cbDeporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDeporte_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Modalidad de la competencia:";
            // 
            // cbModalidad
            // 
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Location = new System.Drawing.Point(197, 101);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(107, 21);
            this.cbModalidad.TabIndex = 4;
            this.cbModalidad.SelectedValueChanged += new System.EventHandler(this.cbModalidad_SelectedValueChanged);
            this.cbModalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbModalidad_KeyDown);
            this.cbModalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbModalidad_KeyPress);
            // 
            // lPtosGanado
            // 
            this.lPtosGanado.AutoSize = true;
            this.lPtosGanado.Enabled = false;
            this.lPtosGanado.Location = new System.Drawing.Point(44, 145);
            this.lPtosGanado.Name = "lPtosGanado";
            this.lPtosGanado.Size = new System.Drawing.Size(135, 13);
            this.lPtosGanado.TabIndex = 53;
            this.lPtosGanado.Text = "Puntos por partido ganado:";
            // 
            // tbPtosGanado
            // 
            this.tbPtosGanado.Enabled = false;
            this.tbPtosGanado.Location = new System.Drawing.Point(179, 142);
            this.tbPtosGanado.MaxLength = 1;
            this.tbPtosGanado.Name = "tbPtosGanado";
            this.tbPtosGanado.Size = new System.Drawing.Size(38, 20);
            this.tbPtosGanado.TabIndex = 5;
            this.tbPtosGanado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPtosGanado_KeyDown);
            this.tbPtosGanado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPtosGanado_KeyPress);
            // 
            // cbEmpate
            // 
            this.cbEmpate.AutoSize = true;
            this.cbEmpate.Enabled = false;
            this.cbEmpate.Location = new System.Drawing.Point(6, 19);
            this.cbEmpate.Name = "cbEmpate";
            this.cbEmpate.Size = new System.Drawing.Size(98, 17);
            this.cbEmpate.TabIndex = 6;
            this.cbEmpate.Text = "Permitir empate";
            this.cbEmpate.UseVisualStyleBackColor = true;
            this.cbEmpate.CheckedChanged += new System.EventHandler(this.cbEmpate_CheckedChanged);
            // 
            // lPtosEmpatado
            // 
            this.lPtosEmpatado.AutoSize = true;
            this.lPtosEmpatado.Enabled = false;
            this.lPtosEmpatado.Location = new System.Drawing.Point(23, 53);
            this.lPtosEmpatado.Name = "lPtosEmpatado";
            this.lPtosEmpatado.Size = new System.Drawing.Size(146, 13);
            this.lPtosEmpatado.TabIndex = 55;
            this.lPtosEmpatado.Text = "Puntos por partido empatado:";
            // 
            // tbPtosEmpatado
            // 
            this.tbPtosEmpatado.Enabled = false;
            this.tbPtosEmpatado.Location = new System.Drawing.Point(175, 50);
            this.tbPtosEmpatado.MaxLength = 1;
            this.tbPtosEmpatado.Name = "tbPtosEmpatado";
            this.tbPtosEmpatado.Size = new System.Drawing.Size(38, 20);
            this.tbPtosEmpatado.TabIndex = 7;
            this.tbPtosEmpatado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPtosEmpatado_KeyDown);
            this.tbPtosEmpatado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPtosEmpatado_KeyPress);
            // 
            // lPtosPresentarse
            // 
            this.lPtosPresentarse.AutoSize = true;
            this.lPtosPresentarse.Enabled = false;
            this.lPtosPresentarse.Location = new System.Drawing.Point(3, 86);
            this.lPtosPresentarse.Name = "lPtosPresentarse";
            this.lPtosPresentarse.Size = new System.Drawing.Size(119, 13);
            this.lPtosPresentarse.TabIndex = 56;
            this.lPtosPresentarse.Text = "Puntos por presentarse:";
            // 
            // tbPtosPresentarse
            // 
            this.tbPtosPresentarse.Enabled = false;
            this.tbPtosPresentarse.Location = new System.Drawing.Point(129, 83);
            this.tbPtosPresentarse.MaxLength = 1;
            this.tbPtosPresentarse.Name = "tbPtosPresentarse";
            this.tbPtosPresentarse.Size = new System.Drawing.Size(38, 20);
            this.tbPtosPresentarse.TabIndex = 8;
            this.tbPtosPresentarse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPtosPresentarse_KeyDown);
            this.tbPtosPresentarse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPtosPresentarse_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmpate);
            this.groupBox1.Controls.Add(this.lPtosEmpatado);
            this.groupBox1.Controls.Add(this.tbPtosPresentarse);
            this.groupBox1.Controls.Add(this.tbPtosEmpatado);
            this.groupBox1.Controls.Add(this.lPtosPresentarse);
            this.groupBox1.Location = new System.Drawing.Point(47, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Forma de puntuación:";
            // 
            // cbFormaPuntuacion
            // 
            this.cbFormaPuntuacion.FormattingEnabled = true;
            this.cbFormaPuntuacion.Location = new System.Drawing.Point(160, 305);
            this.cbFormaPuntuacion.Name = "cbFormaPuntuacion";
            this.cbFormaPuntuacion.Size = new System.Drawing.Size(100, 21);
            this.cbFormaPuntuacion.TabIndex = 9;
            this.cbFormaPuntuacion.SelectedValueChanged += new System.EventHandler(this.cbFormaPuntuacion_SelectedValueChanged);
            this.cbFormaPuntuacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFormaPuntuacion_KeyDown);
            this.cbFormaPuntuacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFormaPuntuacion_KeyPress);
            // 
            // lMaxSet
            // 
            this.lMaxSet.AutoSize = true;
            this.lMaxSet.Enabled = false;
            this.lMaxSet.Location = new System.Drawing.Point(71, 347);
            this.lMaxSet.Name = "lMaxSet";
            this.lMaxSet.Size = new System.Drawing.Size(127, 13);
            this.lMaxSet.TabIndex = 58;
            this.lMaxSet.Text = "Cantidad máxima de sets:";
            // 
            // lNoPresentarse
            // 
            this.lNoPresentarse.AutoSize = true;
            this.lNoPresentarse.Enabled = false;
            this.lNoPresentarse.Location = new System.Drawing.Point(71, 383);
            this.lNoPresentarse.Name = "lNoPresentarse";
            this.lNoPresentarse.Size = new System.Drawing.Size(190, 13);
            this.lNoPresentarse.TabIndex = 59;
            this.lNoPresentarse.Text = "Cantidad de tantos por no presentarse:";
            // 
            // tbNoPresentarse
            // 
            this.tbNoPresentarse.Enabled = false;
            this.tbNoPresentarse.Location = new System.Drawing.Point(266, 380);
            this.tbNoPresentarse.MaxLength = 1;
            this.tbNoPresentarse.Name = "tbNoPresentarse";
            this.tbNoPresentarse.Size = new System.Drawing.Size(38, 20);
            this.tbNoPresentarse.TabIndex = 11;
            this.tbNoPresentarse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNoPresentarse_KeyDown);
            this.tbNoPresentarse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoPresentarse_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Reglamento: (Opcional)";
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(384, 595);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 14;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(472, 595);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 15;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(266, 595);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 13;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // rtbReglamento
            // 
            this.rtbReglamento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbReglamento.Location = new System.Drawing.Point(47, 467);
            this.rtbReglamento.MaxLength = 5000;
            this.rtbReglamento.Name = "rtbReglamento";
            this.rtbReglamento.ShowSelectionMargin = true;
            this.rtbReglamento.Size = new System.Drawing.Size(500, 113);
            this.rtbReglamento.TabIndex = 12;
            this.rtbReglamento.Text = "";
            // 
            // linkLugares
            // 
            this.linkLugares.AutoSize = true;
            this.linkLugares.Location = new System.Drawing.Point(201, 63);
            this.linkLugares.Name = "linkLugares";
            this.linkLugares.Size = new System.Drawing.Size(143, 13);
            this.linkLugares.TabIndex = 3;
            this.linkLugares.TabStop = true;
            this.linkLugares.Text = "Cargar lugares de realización";
            this.linkLugares.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLugares_LinkClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Location = new System.Drawing.Point(229, 439);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel3.Text = "N ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "K ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel1.Text = "S";
            // 
            // cbMaxSet
            // 
            this.cbMaxSet.Enabled = false;
            this.cbMaxSet.FormattingEnabled = true;
            this.cbMaxSet.Items.AddRange(new object[] {
            "3",
            "5",
            "9"});
            this.cbMaxSet.Location = new System.Drawing.Point(204, 344);
            this.cbMaxSet.Name = "cbMaxSet";
            this.cbMaxSet.Size = new System.Drawing.Size(38, 21);
            this.cbMaxSet.TabIndex = 10;
            this.cbMaxSet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDeporte_KeyDown);
            this.cbMaxSet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMaxSet_KeyPress);
            // 
            // comboBox6
            // 
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(47, 440);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(133, 21);
            this.comboBox6.TabIndex = 12;
            this.comboBox6.Text = "Times New Roman";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Sistema de Liga",
            "Eliminatoria Simple",
            "Eliminatorio Doble"});
            this.comboBox3.Location = new System.Drawing.Point(186, 440);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(40, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "10";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel4.Text = "N";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(14, 22);
            this.toolStripLabel5.Text = "K";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel6.Text = "S";
            // 
            // altaCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(598, 639);
            this.Controls.Add(this.cbMaxSet);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkLugares);
            this.Controls.Add(this.rtbReglamento);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNoPresentarse);
            this.Controls.Add(this.lNoPresentarse);
            this.Controls.Add(this.lMaxSet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFormaPuntuacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPtosGanado);
            this.Controls.Add(this.lPtosGanado);
            this.Controls.Add(this.cbModalidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDeporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "altaCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de alta competencia deportiva";
            this.Load += new System.EventHandler(this.altaCompetencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDeporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.Label lPtosGanado;
        private System.Windows.Forms.TextBox tbPtosGanado;
        private System.Windows.Forms.CheckBox cbEmpate;
        private System.Windows.Forms.Label lPtosEmpatado;
        private System.Windows.Forms.TextBox tbPtosEmpatado;
        private System.Windows.Forms.Label lPtosPresentarse;
        private System.Windows.Forms.TextBox tbPtosPresentarse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFormaPuntuacion;
        private System.Windows.Forms.Label lMaxSet;
        private System.Windows.Forms.Label lNoPresentarse;
        private System.Windows.Forms.TextBox tbNoPresentarse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.RichTextBox rtbReglamento;
        private System.Windows.Forms.LinkLabel linkLugares;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox cbMaxSet;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
    }
}