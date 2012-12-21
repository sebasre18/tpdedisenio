namespace TPdeDiseño
{
    partial class gestionaPuntos
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.checkBoxP2 = new System.Windows.Forms.CheckBox();
            this.labelPart2 = new System.Windows.Forms.Label();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.checkBoxP1 = new System.Windows.Forms.CheckBox();
            this.labelPart1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxP2);
            this.groupBox7.Controls.Add(this.checkBoxP2);
            this.groupBox7.Controls.Add(this.labelPart2);
            this.groupBox7.Controls.Add(this.textBoxP1);
            this.groupBox7.Controls.Add(this.checkBoxP1);
            this.groupBox7.Controls.Add(this.labelPart1);
            this.groupBox7.Location = new System.Drawing.Point(34, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(452, 92);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(390, 17);
            this.textBoxP2.MaxLength = 3;
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(43, 20);
            this.textBoxP2.TabIndex = 2;
            this.textBoxP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxP2_KeyPress);
            // 
            // checkBoxP2
            // 
            this.checkBoxP2.AutoSize = true;
            this.checkBoxP2.Location = new System.Drawing.Point(309, 43);
            this.checkBoxP2.Name = "checkBoxP2";
            this.checkBoxP2.Size = new System.Drawing.Size(65, 17);
            this.checkBoxP2.TabIndex = 4;
            this.checkBoxP2.Text = "Ausente";
            this.checkBoxP2.UseVisualStyleBackColor = true;
            // 
            // labelPart2
            // 
            this.labelPart2.AutoSize = true;
            this.labelPart2.Location = new System.Drawing.Point(250, 20);
            this.labelPart2.Name = "labelPart2";
            this.labelPart2.Size = new System.Drawing.Size(20, 13);
            this.labelPart2.TabIndex = 3;
            this.labelPart2.Text = "P2";
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(159, 17);
            this.textBoxP1.MaxLength = 3;
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(43, 20);
            this.textBoxP1.TabIndex = 1;
            this.textBoxP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxP1_KeyPress);
            // 
            // checkBoxP1
            // 
            this.checkBoxP1.AutoSize = true;
            this.checkBoxP1.Location = new System.Drawing.Point(43, 43);
            this.checkBoxP1.Name = "checkBoxP1";
            this.checkBoxP1.Size = new System.Drawing.Size(65, 17);
            this.checkBoxP1.TabIndex = 3;
            this.checkBoxP1.Text = "Ausente";
            this.checkBoxP1.UseVisualStyleBackColor = true;
            // 
            // labelPart1
            // 
            this.labelPart1.AutoSize = true;
            this.labelPart1.Location = new System.Drawing.Point(18, 20);
            this.labelPart1.Name = "labelPart1";
            this.labelPart1.Size = new System.Drawing.Size(20, 13);
            this.labelPart1.TabIndex = 0;
            this.labelPart1.Text = "P1";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(322, 140);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 6;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(411, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(193, 140);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // gestionaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 184);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "gestionaPuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar resultado por puntos";
            this.Load += new System.EventHandler(this.gestionaPuntos_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.CheckBox checkBoxP2;
        private System.Windows.Forms.Label labelPart2;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.CheckBox checkBoxP1;
        private System.Windows.Forms.Label labelPart1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAceptar;
    }
}