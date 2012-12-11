namespace TPdeDiseño
{
    partial class mensajeTipo2
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
            this.labelError2 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(182, 35);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(107, 17);
            this.labelError2.TabIndex = 3;
            this.labelError2.Text = "XXXXXXXXXXX";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(197, 82);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // mensajeTipo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 130);
            this.ControlBox = false;
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "mensajeTipo2";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.mensajeTipo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Button buttonAceptar;
    }
}