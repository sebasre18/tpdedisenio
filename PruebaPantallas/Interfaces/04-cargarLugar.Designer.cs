namespace PruebaPantallas
{
    partial class cargarLugar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lugarRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnosFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lugarRealizacion,
            this.turnosFecha});
            this.dataGridView1.Location = new System.Drawing.Point(35, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 59);
            this.dataGridView1.TabIndex = 30;
            // 
            // lugarRealizacion
            // 
            this.lugarRealizacion.HeaderText = "Lugar de realización";
            this.lugarRealizacion.Name = "lugarRealizacion";
            this.lugarRealizacion.Width = 350;
            // 
            // turnosFecha
            // 
            this.turnosFecha.HeaderText = "Turnos por fecha";
            this.turnosFecha.Name = "turnosFecha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(283, 125);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 31;
            this.aceptar.Text = "Aceptar";
            this.aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // cargarLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cargarLugar";
            this.Text = "Cargar lugares de realización";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnosFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button aceptar;
    }
}