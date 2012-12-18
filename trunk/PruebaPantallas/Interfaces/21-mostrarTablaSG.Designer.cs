﻿namespace TPdeDiseño.Interfaces
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
            this.dataGridViewTablaSG = new System.Windows.Forms.DataGridView();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCompetencia = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaSG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTablaSG
            // 
            this.dataGridViewTablaSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaSG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipo,
            this.pts,
            this.pg,
            this.pe,
            this.pp});
            this.dataGridViewTablaSG.Location = new System.Drawing.Point(21, 71);
            this.dataGridViewTablaSG.Name = "dataGridViewTablaSG";
            this.dataGridViewTablaSG.Size = new System.Drawing.Size(364, 46);
            this.dataGridViewTablaSG.TabIndex = 3;
            // 
            // equipo
            // 
            this.equipo.HeaderText = "Equipo";
            this.equipo.Name = "equipo";
            this.equipo.Width = 200;
            // 
            // pts
            // 
            this.pts.FillWeight = 35F;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(208, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(118, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mostrarTablaSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 179);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewTablaSG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mostrarTablaSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de posiciones sin goles";
            this.Load += new System.EventHandler(this.mostrarTablaSG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaSG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablaSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCompetencia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}