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
            this.dgvTablaCG = new System.Windows.Forms.DataGridView();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bExportar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCompetencia = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablaCG
            // 
            this.dgvTablaCG.AllowUserToAddRows = false;
            this.dgvTablaCG.AllowUserToDeleteRows = false;
            this.dgvTablaCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipo,
            this.pts,
            this.pg,
            this.pe,
            this.pp,
            this.gf,
            this.gc,
            this.d});
            this.dgvTablaCG.Location = new System.Drawing.Point(21, 61);
            this.dgvTablaCG.Name = "dgvTablaCG";
            this.dgvTablaCG.ReadOnly = true;
            this.dgvTablaCG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTablaCG.Size = new System.Drawing.Size(455, 282);
            this.dgvTablaCG.TabIndex = 0;
            // 
            // equipo
            // 
            this.equipo.HeaderText = "Equipo";
            this.equipo.MaxInputLength = 50;
            this.equipo.Name = "equipo";
            this.equipo.ReadOnly = true;
            this.equipo.Width = 200;
            // 
            // pts
            // 
            this.pts.HeaderText = "PTS";
            this.pts.MaxInputLength = 100;
            this.pts.Name = "pts";
            this.pts.ReadOnly = true;
            this.pts.Width = 30;
            // 
            // pg
            // 
            this.pg.HeaderText = "PG";
            this.pg.MaxInputLength = 100;
            this.pg.Name = "pg";
            this.pg.ReadOnly = true;
            this.pg.Width = 30;
            // 
            // pe
            // 
            this.pe.HeaderText = "PE";
            this.pe.MaxInputLength = 100;
            this.pe.Name = "pe";
            this.pe.ReadOnly = true;
            this.pe.Width = 30;
            // 
            // pp
            // 
            this.pp.HeaderText = "PP";
            this.pp.MaxInputLength = 100;
            this.pp.Name = "pp";
            this.pp.ReadOnly = true;
            this.pp.Width = 30;
            // 
            // gf
            // 
            this.gf.HeaderText = "GF";
            this.gf.MaxInputLength = 100;
            this.gf.Name = "gf";
            this.gf.ReadOnly = true;
            this.gf.Width = 30;
            // 
            // gc
            // 
            this.gc.HeaderText = "GC";
            this.gc.MaxInputLength = 100;
            this.gc.Name = "gc";
            this.gc.ReadOnly = true;
            this.gc.Width = 30;
            // 
            // d
            // 
            this.d.HeaderText = "D";
            this.d.MaxInputLength = 100;
            this.d.Name = "d";
            this.d.ReadOnly = true;
            this.d.Width = 30;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(410, 378);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bImprimir
            // 
            this.bImprimir.Location = new System.Drawing.Point(298, 378);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 23);
            this.bImprimir.TabIndex = 8;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bExportar
            // 
            this.bExportar.Location = new System.Drawing.Point(208, 378);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(75, 23);
            this.bExportar.TabIndex = 7;
            this.bExportar.Text = "Exportar";
            this.bExportar.UseVisualStyleBackColor = true;
            this.bExportar.Click += new System.EventHandler(this.buttonExportar_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // mostrarTablaCG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.dgvTablaCG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "mostrarTablaCG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de posiciones con goles";
            this.Load += new System.EventHandler(this.mostrarTablaCG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaCG;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gf;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}