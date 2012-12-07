namespace TPdeDiseño
{
    partial class registroUsuario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.Label();
            this.repetirContrasena = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tipoDoc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numeroDoc = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.provincia = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.aceptoTerminos = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(110, 410);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(48, 31);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 2;
            this.email.Text = "E-mail:";
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Location = new System.Drawing.Point(48, 72);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(64, 13);
            this.contrasena.TabIndex = 3;
            this.contrasena.Text = "Contraseña:";
            // 
            // repetirContrasena
            // 
            this.repetirContrasena.AutoSize = true;
            this.repetirContrasena.Location = new System.Drawing.Point(48, 112);
            this.repetirContrasena.Name = "repetirContrasena";
            this.repetirContrasena.Size = new System.Drawing.Size(100, 13);
            this.repetirContrasena.TabIndex = 4;
            this.repetirContrasena.Text = "Repetir contraseña:";
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.Location = new System.Drawing.Point(48, 153);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(52, 13);
            this.apellidos.TabIndex = 5;
            this.apellidos.Text = "Apellidos:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(48, 195);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 20);
            this.textBox4.TabIndex = 10;
            // 
            // tipoDoc
            // 
            this.tipoDoc.AutoSize = true;
            this.tipoDoc.Location = new System.Drawing.Point(48, 237);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(31, 13);
            this.tipoDoc.TabIndex = 11;
            this.tipoDoc.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.comboBox1.Location = new System.Drawing.Point(85, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numeroDoc
            // 
            this.numeroDoc.AutoSize = true;
            this.numeroDoc.Location = new System.Drawing.Point(168, 237);
            this.numeroDoc.Name = "numeroDoc";
            this.numeroDoc.Size = new System.Drawing.Size(47, 13);
            this.numeroDoc.TabIndex = 13;
            this.numeroDoc.Text = "Número:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(290, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(221, 234);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.comboBox2.Location = new System.Drawing.Point(108, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // provincia
            // 
            this.provincia.AutoSize = true;
            this.provincia.Location = new System.Drawing.Point(48, 277);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(54, 13);
            this.provincia.TabIndex = 18;
            this.provincia.Text = "Provincia:";
            // 
            // localidad
            // 
            this.localidad.AutoSize = true;
            this.localidad.Location = new System.Drawing.Point(48, 316);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(56, 13);
            this.localidad.TabIndex = 19;
            this.localidad.Text = "Localidad:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.comboBox3.Location = new System.Drawing.Point(110, 313);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(281, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // aceptoTerminos
            // 
            this.aceptoTerminos.AutoSize = true;
            this.aceptoTerminos.Location = new System.Drawing.Point(51, 350);
            this.aceptoTerminos.Name = "aceptoTerminos";
            this.aceptoTerminos.Size = new System.Drawing.Size(15, 14);
            this.aceptoTerminos.TabIndex = 21;
            this.aceptoTerminos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(72, 350);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Acepto los términos y condiciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(102, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ejemplo@ejemplo.com";
            // 
            // registroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aceptoTerminos);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.numeroDoc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tipoDoc);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.repetirContrasena);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aceptar);
            this.Name = "registroUsuario";
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Label repetirContrasena;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label tipoDoc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label numeroDoc;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label provincia;
        private System.Windows.Forms.Label localidad;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox aceptoTerminos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}

