namespace TPdeDiseño
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
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            this.lugarRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnosFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLugares
            // 
            this.dgvLugares.AllowUserToAddRows = false;
            this.dgvLugares.AllowUserToDeleteRows = false;
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lugarRealizacion,
            this.turnosFecha});
            this.dgvLugares.Location = new System.Drawing.Point(35, 33);
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.Size = new System.Drawing.Size(495, 86);
            this.dgvLugares.TabIndex = 30;
            this.dgvLugares.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvLugares_EditingControlShowing);
            this.dgvLugares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvLugares_KeyPress);
            // 
            // lugarRealizacion
            // 
            this.lugarRealizacion.HeaderText = "Lugar de realización";
            this.lugarRealizacion.Name = "lugarRealizacion";
            this.lugarRealizacion.ReadOnly = true;
            this.lugarRealizacion.Width = 350;
            // 
            // turnosFecha
            // 
            this.turnosFecha.HeaderText = "Turnos por fecha";
            this.turnosFecha.Name = "turnosFecha";
            this.turnosFecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(375, 171);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 33;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(455, 171);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 32;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(281, 171);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 31;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // cargarLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 206);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.dgvLugares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "cargarLugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar lugares de realización";
            this.Load += new System.EventHandler(this.cargarLugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnosFecha;
    }
}