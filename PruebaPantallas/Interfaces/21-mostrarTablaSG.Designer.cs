namespace TPdeDiseño.Interfaces
{
    partial class mostrarTablaSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mostrarTablaSG));
            this.dgvTablaSG = new System.Windows.Forms.DataGridView();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCompetencia = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bExportar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablaSG
            // 
            this.dgvTablaSG.AllowUserToAddRows = false;
            this.dgvTablaSG.AllowUserToDeleteRows = false;
            this.dgvTablaSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipo,
            this.pts,
            this.pg,
            this.pe,
            this.pp});
            this.dgvTablaSG.Location = new System.Drawing.Point(21, 71);
            this.dgvTablaSG.Name = "dgvTablaSG";
            this.dgvTablaSG.ReadOnly = true;
            this.dgvTablaSG.Size = new System.Drawing.Size(364, 306);
            this.dgvTablaSG.TabIndex = 3;
            // 
            // equipo
            // 
            this.equipo.HeaderText = "Equipo";
            this.equipo.Name = "equipo";
            this.equipo.ReadOnly = true;
            this.equipo.Width = 200;
            // 
            // pts
            // 
            this.pts.FillWeight = 35F;
            this.pts.HeaderText = "PTS";
            this.pts.Name = "pts";
            this.pts.ReadOnly = true;
            this.pts.Width = 30;
            // 
            // pg
            // 
            this.pg.HeaderText = "PG";
            this.pg.Name = "pg";
            this.pg.ReadOnly = true;
            this.pg.Width = 30;
            // 
            // pe
            // 
            this.pe.HeaderText = "PE";
            this.pe.Name = "pe";
            this.pe.ReadOnly = true;
            this.pe.Width = 30;
            // 
            // pp
            // 
            this.pp.HeaderText = "PP";
            this.pp.Name = "pp";
            this.pp.ReadOnly = true;
            this.pp.Width = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCompetencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 42);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // labelCompetencia
            // 
            this.labelCompetencia.AutoSize = true;
            this.labelCompetencia.Location = new System.Drawing.Point(6, 16);
            this.labelCompetencia.Name = "labelCompetencia";
            this.labelCompetencia.Size = new System.Drawing.Size(28, 13);
            this.labelCompetencia.TabIndex = 21;
            this.labelCompetencia.Text = "XXX";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(320, 400);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 24;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bImprimir
            // 
            this.bImprimir.Enabled = false;
            this.bImprimir.Location = new System.Drawing.Point(208, 400);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 23);
            this.bImprimir.TabIndex = 23;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bExportar
            // 
            this.bExportar.Enabled = false;
            this.bExportar.Location = new System.Drawing.Point(118, 400);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(75, 23);
            this.bExportar.TabIndex = 22;
            this.bExportar.Text = "Exportar";
            this.bExportar.UseVisualStyleBackColor = true;
            this.bExportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // mostrarTablaSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 435);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.dgvTablaSG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mostrarTablaSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de posiciones sin goles";
            this.Load += new System.EventHandler(this.mostrarTablaSG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCompetencia;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button bExportar;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}