namespace TPdeDiseño
{
    partial class verCompetencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verCompetencia));
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreComp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelModComp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDeporteComp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEstadoComp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxParticipantes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxProxEncuentros = new System.Windows.Forms.ListBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonVerFixture = new System.Windows.Forms.Button();
            this.buttonTabla = new System.Windows.Forms.Button();
            this.buttonGenerarF = new System.Windows.Forms.Button();
            this.buttonParticipantes = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // labelNombreComp
            // 
            this.labelNombreComp.AutoSize = true;
            this.labelNombreComp.Location = new System.Drawing.Point(108, 22);
            this.labelNombreComp.Name = "labelNombreComp";
            this.labelNombreComp.Size = new System.Drawing.Size(56, 13);
            this.labelNombreComp.TabIndex = 1;
            this.labelNombreComp.Text = "NomComp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modalidad:";
            // 
            // labelModComp
            // 
            this.labelModComp.AutoSize = true;
            this.labelModComp.Location = new System.Drawing.Point(119, 46);
            this.labelModComp.Name = "labelModComp";
            this.labelModComp.Size = new System.Drawing.Size(55, 13);
            this.labelModComp.TabIndex = 1;
            this.labelModComp.Text = "ModComp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Deporte:";
            // 
            // labelDeporteComp
            // 
            this.labelDeporteComp.AutoSize = true;
            this.labelDeporteComp.Location = new System.Drawing.Point(108, 69);
            this.labelDeporteComp.Name = "labelDeporteComp";
            this.labelDeporteComp.Size = new System.Drawing.Size(54, 13);
            this.labelDeporteComp.TabIndex = 1;
            this.labelDeporteComp.Text = "DepComp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado:";
            // 
            // labelEstadoComp
            // 
            this.labelEstadoComp.AutoSize = true;
            this.labelEstadoComp.Location = new System.Drawing.Point(103, 93);
            this.labelEstadoComp.Name = "labelEstadoComp";
            this.labelEstadoComp.Size = new System.Drawing.Size(49, 13);
            this.labelEstadoComp.TabIndex = 1;
            this.labelEstadoComp.Text = "EstComp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Participantes:";
            // 
            // listBoxParticipantes
            // 
            this.listBoxParticipantes.FormattingEnabled = true;
            this.listBoxParticipantes.Location = new System.Drawing.Point(57, 136);
            this.listBoxParticipantes.Name = "listBoxParticipantes";
            this.listBoxParticipantes.Size = new System.Drawing.Size(332, 147);
            this.listBoxParticipantes.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Próximos encuentros:";
            // 
            // listBoxProxEncuentros
            // 
            this.listBoxProxEncuentros.FormattingEnabled = true;
            this.listBoxProxEncuentros.Location = new System.Drawing.Point(57, 317);
            this.listBoxProxEncuentros.Name = "listBoxProxEncuentros";
            this.listBoxProxEncuentros.ScrollAlwaysVisible = true;
            this.listBoxProxEncuentros.Size = new System.Drawing.Size(332, 147);
            this.listBoxProxEncuentros.TabIndex = 2;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(124, 516);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(205, 516);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(75, 23);
            this.buttonBaja.TabIndex = 3;
            this.buttonBaja.Text = "Dar de baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonVerFixture
            // 
            this.buttonVerFixture.Location = new System.Drawing.Point(205, 487);
            this.buttonVerFixture.Name = "buttonVerFixture";
            this.buttonVerFixture.Size = new System.Drawing.Size(75, 23);
            this.buttonVerFixture.TabIndex = 3;
            this.buttonVerFixture.Text = "Ver fixture";
            this.buttonVerFixture.UseVisualStyleBackColor = true;
            this.buttonVerFixture.Click += new System.EventHandler(this.buttonVerFixture_Click_1);
            // 
            // buttonTabla
            // 
            this.buttonTabla.Location = new System.Drawing.Point(75, 487);
            this.buttonTabla.Name = "buttonTabla";
            this.buttonTabla.Size = new System.Drawing.Size(124, 23);
            this.buttonTabla.TabIndex = 3;
            this.buttonTabla.Text = "Tabla de posiciones";
            this.buttonTabla.UseVisualStyleBackColor = true;
            this.buttonTabla.Click += new System.EventHandler(this.buttonTabla_Click);
            // 
            // buttonGenerarF
            // 
            this.buttonGenerarF.Location = new System.Drawing.Point(286, 487);
            this.buttonGenerarF.Name = "buttonGenerarF";
            this.buttonGenerarF.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerarF.TabIndex = 3;
            this.buttonGenerarF.Text = "Generar fixture";
            this.buttonGenerarF.UseVisualStyleBackColor = true;
            this.buttonGenerarF.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonParticipantes
            // 
            this.buttonParticipantes.Location = new System.Drawing.Point(286, 516);
            this.buttonParticipantes.Name = "buttonParticipantes";
            this.buttonParticipantes.Size = new System.Drawing.Size(103, 23);
            this.buttonParticipantes.TabIndex = 3;
            this.buttonParticipantes.Text = "Datos participante";
            this.buttonParticipantes.UseVisualStyleBackColor = true;
            this.buttonParticipantes.Click += new System.EventHandler(this.buttonParticipantes_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(309, 565);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(80, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // verCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 609);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonParticipantes);
            this.Controls.Add(this.buttonGenerarF);
            this.Controls.Add(this.buttonTabla);
            this.Controls.Add(this.buttonVerFixture);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.listBoxProxEncuentros);
            this.Controls.Add(this.listBoxParticipantes);
            this.Controls.Add(this.labelEstadoComp);
            this.Controls.Add(this.labelDeporteComp);
            this.Controls.Add(this.labelModComp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNombreComp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "verCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver competencia";
            this.Load += new System.EventHandler(this.verCompetencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelModComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDeporteComp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEstadoComp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxParticipantes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxProxEncuentros;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonVerFixture;
        private System.Windows.Forms.Button buttonTabla;
        private System.Windows.Forms.Button buttonGenerarF;
        private System.Windows.Forms.Button buttonParticipantes;
        private System.Windows.Forms.Button buttonCancelar;
    }
}