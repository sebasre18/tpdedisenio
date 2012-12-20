namespace TPdeDiseño
{
    partial class listarCompetencias
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreLugar = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompetencia = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(508, 401);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 22;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(417, 401);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(75, 23);
            this.bVer.TabIndex = 21;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.EnabledChanged += new System.EventHandler(this.bVer_Click);
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Enabled = false;
            this.bLimpiar.Location = new System.Drawing.Point(508, 167);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 19;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Enabled = false;
            this.bBuscar.Location = new System.Drawing.Point(417, 167);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 18;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fútbol",
            "Basquet",
            "Tenis"});
            this.comboBox1.Location = new System.Drawing.Point(90, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(179, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Deporte:";
            // 
            // nombreLugar
            // 
            this.nombreLugar.AutoSize = true;
            this.nombreLugar.Location = new System.Drawing.Point(36, 30);
            this.nombreLugar.Name = "nombreLugar";
            this.nombreLugar.Size = new System.Drawing.Size(137, 13);
            this.nombreLugar.TabIndex = 13;
            this.nombreLugar.Text = "Nombre de la competencia:";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sistema de Liga",
            "Eliminatoria Simple",
            "Eliminatorio Doble"});
            this.comboBox2.Location = new System.Drawing.Point(101, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Modalidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Estado:";
            // 
            // dgvCompetencia
            // 
            this.dgvCompetencia.AllowUserToAddRows = false;
            this.dgvCompetencia.AllowUserToDeleteRows = false;
            this.dgvCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.deporte,
            this.modalidad,
            this.estado});
            this.dgvCompetencia.Location = new System.Drawing.Point(39, 222);
            this.dgvCompetencia.MultiSelect = false;
            this.dgvCompetencia.Name = "dgvCompetencia";
            this.dgvCompetencia.ReadOnly = true;
            this.dgvCompetencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetencia.Size = new System.Drawing.Size(544, 145);
            this.dgvCompetencia.TabIndex = 28;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // deporte
            // 
            this.deporte.HeaderText = "Deporte";
            this.deporte.Name = "deporte";
            this.deporte.ReadOnly = true;
            // 
            // modalidad
            // 
            this.modalidad.HeaderText = "Modalidad";
            this.modalidad.Name = "modalidad";
            this.modalidad.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Creada",
            "Planificada",
            "En disputa",
            "Finalizada"});
            this.comboBox3.Location = new System.Drawing.Point(85, 133);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(107, 21);
            this.comboBox3.TabIndex = 30;
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(325, 401);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 29;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // listarCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 448);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.dgvCompetencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreLugar);
            this.MaximizeBox = false;
            this.Name = "listarCompetencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar competencias deportivas";
            this.Load += new System.EventHandler(this.listarCompetencias_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreLugar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompetencia;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button bNuevo;
    }
}