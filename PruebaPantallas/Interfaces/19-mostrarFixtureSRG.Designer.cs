namespace TPdeDiseño
{
    partial class mostrarFixtureSRG
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModRdo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridPartidos = new System.Windows.Forms.DataGridView();
            this.local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadolocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoVisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNombreComp = new System.Windows.Forms.Label();
            this.comboBoxNroRonda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(482, 365);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonModRdo
            // 
            this.buttonModRdo.Enabled = false;
            this.buttonModRdo.Location = new System.Drawing.Point(351, 365);
            this.buttonModRdo.Name = "buttonModRdo";
            this.buttonModRdo.Size = new System.Drawing.Size(112, 23);
            this.buttonModRdo.TabIndex = 3;
            this.buttonModRdo.Text = "Modificar resultado";
            this.buttonModRdo.UseVisualStyleBackColor = true;
            this.buttonModRdo.Click += new System.EventHandler(this.buttonModRdo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPartidos);
            this.groupBox2.Location = new System.Drawing.Point(31, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 257);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // dataGridPartidos
            // 
            this.dataGridPartidos.AllowUserToAddRows = false;
            this.dataGridPartidos.AllowUserToDeleteRows = false;
            this.dataGridPartidos.AllowUserToOrderColumns = true;
            this.dataGridPartidos.AllowUserToResizeColumns = false;
            this.dataGridPartidos.AllowUserToResizeRows = false;
            this.dataGridPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.local,
            this.resultadolocal,
            this.resultadoVisitante,
            this.visitante});
            this.dataGridPartidos.Location = new System.Drawing.Point(6, 19);
            this.dataGridPartidos.MultiSelect = false;
            this.dataGridPartidos.Name = "dataGridPartidos";
            this.dataGridPartidos.ReadOnly = true;
            this.dataGridPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartidos.Size = new System.Drawing.Size(514, 232);
            this.dataGridPartidos.StandardTab = true;
            this.dataGridPartidos.TabIndex = 2;
            this.dataGridPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPartidos_CellContentClick);
            // 
            // local
            // 
            this.local.HeaderText = "Local";
            this.local.Name = "local";
            this.local.ReadOnly = true;
            this.local.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.local.Width = 200;
            // 
            // resultadolocal
            // 
            this.resultadolocal.HeaderText = "";
            this.resultadolocal.Name = "resultadolocal";
            this.resultadolocal.ReadOnly = true;
            this.resultadolocal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resultadolocal.Width = 35;
            // 
            // resultadoVisitante
            // 
            this.resultadoVisitante.HeaderText = "";
            this.resultadoVisitante.Name = "resultadoVisitante";
            this.resultadoVisitante.ReadOnly = true;
            this.resultadoVisitante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resultadoVisitante.Width = 35;
            // 
            // visitante
            // 
            this.visitante.HeaderText = "Visitante";
            this.visitante.Name = "visitante";
            this.visitante.ReadOnly = true;
            this.visitante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.visitante.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNombreComp);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 42);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // labelNombreComp
            // 
            this.labelNombreComp.AutoSize = true;
            this.labelNombreComp.Location = new System.Drawing.Point(6, 16);
            this.labelNombreComp.Name = "labelNombreComp";
            this.labelNombreComp.Size = new System.Drawing.Size(34, 13);
            this.labelNombreComp.TabIndex = 21;
            this.labelNombreComp.Text = "Comp";
            // 
            // comboBoxNroRonda
            // 
            this.comboBoxNroRonda.FormattingEnabled = true;
            this.comboBoxNroRonda.Location = new System.Drawing.Point(113, 13);
            this.comboBoxNroRonda.Name = "comboBoxNroRonda";
            this.comboBoxNroRonda.Size = new System.Drawing.Size(68, 21);
            this.comboBoxNroRonda.Sorted = true;
            this.comboBoxNroRonda.TabIndex = 1;
            this.comboBoxNroRonda.SelectedIndexChanged += new System.EventHandler(this.comboBoxNroRonda_SelectedIndexChanged);
            this.comboBoxNroRonda.SelectedValueChanged += new System.EventHandler(this.comboBoxNroRonda_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Seleccione la ronda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxNroRonda);
            this.groupBox3.Location = new System.Drawing.Point(31, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 42);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // mostrarFixtureSRG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonModRdo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mostrarFixtureSRG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar fixture ";
            this.Load += new System.EventHandler(this.mostrarFixtureSRG_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModRdo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridPartidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn local;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadolocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoVisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNombreComp;
        private System.Windows.Forms.ComboBox comboBoxNroRonda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;

    }
}