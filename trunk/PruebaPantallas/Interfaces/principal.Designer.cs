namespace TPdeDiseño
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaCompetencia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarCompetencias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarLugares = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesInvitadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodasLasCompetenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIniciar,
            this.tsmiSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // tsmiIniciar
            // 
            this.tsmiIniciar.Name = "tsmiIniciar";
            this.tsmiIniciar.Size = new System.Drawing.Size(142, 22);
            this.tsmiIniciar.Text = "Iniciar sesión";
            this.tsmiIniciar.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(142, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaCompetencia,
            this.tsmiListarCompetencias,
            this.tsmiListarLugares,
            this.cerrarSesiónToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.accionesToolStripMenuItem.Enabled = false;
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.accionesToolStripMenuItem.Text = "Usuario";
            // 
            // tsmiAltaCompetencia
            // 
            this.tsmiAltaCompetencia.Enabled = false;
            this.tsmiAltaCompetencia.Name = "tsmiAltaCompetencia";
            this.tsmiAltaCompetencia.Size = new System.Drawing.Size(202, 22);
            this.tsmiAltaCompetencia.Text = "Dar de alta competencia";
            this.tsmiAltaCompetencia.Click += new System.EventHandler(this.tsmiAltaCompetencia_Click);
            // 
            // tsmiListarCompetencias
            // 
            this.tsmiListarCompetencias.Enabled = false;
            this.tsmiListarCompetencias.Name = "tsmiListarCompetencias";
            this.tsmiListarCompetencias.Size = new System.Drawing.Size(202, 22);
            this.tsmiListarCompetencias.Text = "Listar competencias";
            this.tsmiListarCompetencias.Click += new System.EventHandler(this.tsmiListarCompetencias_Click);
            // 
            // tsmiListarLugares
            // 
            this.tsmiListarLugares.Enabled = false;
            this.tsmiListarLugares.Name = "tsmiListarLugares";
            this.tsmiListarLugares.Size = new System.Drawing.Size(202, 22);
            this.tsmiListarLugares.Text = "Listar lugares";
            this.tsmiListarLugares.Click += new System.EventHandler(this.tsmiListarLugares_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Enabled = false;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Enabled = false;
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            // 
            // accionesInvitadoToolStripMenuItem
            // 
            this.accionesInvitadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodasLasCompetenciasToolStripMenuItem});
            this.accionesInvitadoToolStripMenuItem.Name = "accionesInvitadoToolStripMenuItem";
            this.accionesInvitadoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.accionesInvitadoToolStripMenuItem.Text = "Invitado";
            // 
            // listarTodasLasCompetenciasToolStripMenuItem
            // 
            this.listarTodasLasCompetenciasToolStripMenuItem.Name = "listarTodasLasCompetenciasToolStripMenuItem";
            this.listarTodasLasCompetenciasToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.listarTodasLasCompetenciasToolStripMenuItem.Text = "Listar todas las competencias";
            this.listarTodasLasCompetenciasToolStripMenuItem.Click += new System.EventHandler(this.listarTodasLasCompetenciasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.verAyudaToolStripMenuItem.Text = "Ver ayuda";
            this.verAyudaToolStripMenuItem.Click += new System.EventHandler(this.verAyudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 672);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiIniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaCompetencia;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarCompetencias;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarLugares;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesInvitadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodasLasCompetenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
    }
}