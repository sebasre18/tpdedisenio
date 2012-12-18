namespace TPdeDiseño
{
    partial class gestionaGanador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionaGanador));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButtonEmpate = new System.Windows.Forms.RadioButton();
            this.radioButtonP2 = new System.Windows.Forms.RadioButton();
            this.radioButtonP1 = new System.Windows.Forms.RadioButton();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButtonEmpate);
            this.groupBox7.Controls.Add(this.radioButtonP2);
            this.groupBox7.Controls.Add(this.radioButtonP1);
            this.groupBox7.Location = new System.Drawing.Point(33, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(452, 92);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            // 
            // radioButtonEmpate
            // 
            this.radioButtonEmpate.AutoSize = true;
            this.radioButtonEmpate.Location = new System.Drawing.Point(190, 56);
            this.radioButtonEmpate.Name = "radioButtonEmpate";
            this.radioButtonEmpate.Size = new System.Drawing.Size(61, 17);
            this.radioButtonEmpate.TabIndex = 8;
            this.radioButtonEmpate.TabStop = true;
            this.radioButtonEmpate.Text = "Empate";
            this.radioButtonEmpate.UseVisualStyleBackColor = true;
            this.radioButtonEmpate.CheckedChanged += new System.EventHandler(this.radioButtonEmpate_CheckedChanged);
            // 
            // radioButtonP2
            // 
            this.radioButtonP2.AutoSize = true;
            this.radioButtonP2.Location = new System.Drawing.Point(302, 19);
            this.radioButtonP2.Name = "radioButtonP2";
            this.radioButtonP2.Size = new System.Drawing.Size(38, 17);
            this.radioButtonP2.TabIndex = 7;
            this.radioButtonP2.TabStop = true;
            this.radioButtonP2.Text = "P2";
            this.radioButtonP2.UseVisualStyleBackColor = true;
            // 
            // radioButtonP1
            // 
            this.radioButtonP1.AutoSize = true;
            this.radioButtonP1.Location = new System.Drawing.Point(24, 19);
            this.radioButtonP1.Name = "radioButtonP1";
            this.radioButtonP1.Size = new System.Drawing.Size(38, 17);
            this.radioButtonP1.TabIndex = 6;
            this.radioButtonP1.TabStop = true;
            this.radioButtonP1.Text = "P1";
            this.radioButtonP1.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(321, 136);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 23;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(410, 136);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(192, 136);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 21;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // gestionaGanador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 184);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gestionaGanador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar resultado por ganador";
            this.Load += new System.EventHandler(this.gestionaGanador_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.RadioButton radioButtonP2;
        private System.Windows.Forms.RadioButton radioButtonP1;
        private System.Windows.Forms.RadioButton radioButtonEmpate;
    }
}