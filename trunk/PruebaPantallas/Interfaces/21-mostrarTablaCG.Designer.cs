namespace TPdeDiseño.Interfases
{
    partial class mostrarTablaCG
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
            this.dataGridViewTablaCG = new System.Windows.Forms.DataGridView();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCompetencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaCG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTablaCG
            // 
            this.dataGridViewTablaCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaCG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipo,
            this.pts,
            this.pg,
            this.pe,
            this.pp,
            this.gf,
            this.gc,
            this.d});
            this.dataGridViewTablaCG.Location = new System.Drawing.Point(21, 61);
            this.dataGridViewTablaCG.Name = "dataGridViewTablaCG";
            this.dataGridViewTablaCG.Size = new System.Drawing.Size(455, 46);
            this.dataGridViewTablaCG.TabIndex = 0;
            // 
            // equipo
            // 
            this.equipo.HeaderText = "Equipo";
            this.equipo.Name = "equipo";
            this.equipo.Width = 200;
            // 
            // pts
            // 
            this.pts.HeaderText = "PTS";
            this.pts.Name = "pts";
            this.pts.Width = 30;
            // 
            // pg
            // 
            this.pg.HeaderText = "PG";
            this.pg.Name = "pg";
            this.pg.Width = 30;
            // 
            // pe
            // 
            this.pe.HeaderText = "PE";
            this.pe.Name = "pe";
            this.pe.Width = 30;
            // 
            // pp
            // 
            this.pp.HeaderText = "PP";
            this.pp.Name = "pp";
            this.pp.Width = 30;
            // 
            // gf
            // 
            this.gf.HeaderText = "GF";
            this.gf.Name = "gf";
            this.gf.Width = 30;
            // 
            // gc
            // 
            this.gc.HeaderText = "GC";
            this.gc.Name = "gc";
            this.gc.Width = 30;
            // 
            // d
            // 
            this.d.HeaderText = "D";
            this.d.Name = "d";
            this.d.Width = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(298, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(208, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCompetencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 42);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // labelCompetencia
            // 
            this.labelCompetencia.AutoSize = true;
            this.labelCompetencia.Location = new System.Drawing.Point(6, 16);
            this.labelCompetencia.Name = "labelCompetencia";
            this.labelCompetencia.Size = new System.Drawing.Size(203, 13);
            this.labelCompetencia.TabIndex = 21;
            this.labelCompetencia.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // mostrarTablaCG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewTablaCG);
            this.Name = "mostrarTablaCG";
            this.Text = "Tabla de posiciones con goles";
            this.Load += new System.EventHandler(this.mostrarTablaCG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaCG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablaCG;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gf;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCompetencia;
    }
}