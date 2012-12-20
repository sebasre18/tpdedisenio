namespace TPdeDiseño
{
    partial class autentificarUsuario
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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPass.Location = new System.Drawing.Point(45, 129);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(252, 20);
            this.tbPass.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEmail.Location = new System.Drawing.Point(45, 75);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(252, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Location = new System.Drawing.Point(42, 113);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(64, 13);
            this.contrasena.TabIndex = 10;
            this.contrasena.Text = "Contraseña:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(42, 59);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 9;
            this.email.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Si usted está registrado ingrese sus datos:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(45, 215);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 4;
            this.aceptar.Text = "Aceptar";
            this.aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Registrar nuevo usuario";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ejemplo@ejemplo.com";
            // 
            // autentificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "autentificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificar usuario";
            this.Load += new System.EventHandler(this.autentificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}