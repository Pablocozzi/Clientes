namespace ExamenFinal_CozziPablo
{
    partial class frmSistemaGestionClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.busquedaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoPorCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeUnaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeUnBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.listarClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDelDesarrolladorDelSistemaToolStripMenuItem
            // 
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Name = "acercaDelDesarrolladorDelSistemaToolStripMenuItem";
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Text = "Acerca del desarrollador del sistema...";
            this.acercaDelDesarrolladorDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelDesarrolladorDelSistemaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(408, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoSocioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.busquedaDeClientesToolStripMenuItem,
            this.listarDeudoresToolStripMenuItem,
            this.toolStripSeparator2,
            this.listadoPorCiudadToolStripMenuItem,
            this.listadoDeSociosDeudoresToolStripMenuItem,
            this.listadoDeSociosDeUnaActividadToolStripMenuItem,
            this.listadoDeSociosDeUnBarrioToolStripMenuItem});
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.listarClientesToolStripMenuItem.Text = "Socios";
            // 
            // agregarNuevoSocioToolStripMenuItem
            // 
            this.agregarNuevoSocioToolStripMenuItem.Name = "agregarNuevoSocioToolStripMenuItem";
            this.agregarNuevoSocioToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.agregarNuevoSocioToolStripMenuItem.Text = "Agregar nuevo socio...";
            this.agregarNuevoSocioToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoSocioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(395, 6);
            // 
            // busquedaDeClientesToolStripMenuItem
            // 
            this.busquedaDeClientesToolStripMenuItem.Name = "busquedaDeClientesToolStripMenuItem";
            this.busquedaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.busquedaDeClientesToolStripMenuItem.Text = "Buscar socio...";
            this.busquedaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeClientesToolStripMenuItem_Click);
            // 
            // listarDeudoresToolStripMenuItem
            // 
            this.listarDeudoresToolStripMenuItem.Name = "listarDeudoresToolStripMenuItem";
            this.listarDeudoresToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.listarDeudoresToolStripMenuItem.Text = "Consulta de un socio...";
            this.listarDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listarDeudoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(395, 6);
            // 
            // listadoPorCiudadToolStripMenuItem
            // 
            this.listadoPorCiudadToolStripMenuItem.Name = "listadoPorCiudadToolStripMenuItem";
            this.listadoPorCiudadToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.listadoPorCiudadToolStripMenuItem.Text = "Listado de todos los socios...";
            this.listadoPorCiudadToolStripMenuItem.Click += new System.EventHandler(this.listadoPorCiudadToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeudoresToolStripMenuItem
            // 
            this.listadoDeSociosDeudoresToolStripMenuItem.Name = "listadoDeSociosDeudoresToolStripMenuItem";
            this.listadoDeSociosDeudoresToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.listadoDeSociosDeudoresToolStripMenuItem.Text = "Listado de socios deudores...";
            this.listadoDeSociosDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeudoresToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeUnaActividadToolStripMenuItem
            // 
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Name = "listadoDeSociosDeUnaActividadToolStripMenuItem";
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Text = "Listado de socios de una actividad...";
            this.listadoDeSociosDeUnaActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeUnaActividadToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeUnBarrioToolStripMenuItem
            // 
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Name = "listadoDeSociosDeUnBarrioToolStripMenuItem";
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Size = new System.Drawing.Size(398, 34);
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Text = "Listado de socios de un barrio...";
            this.listadoDeSociosDeUnBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeUnBarrioToolStripMenuItem_Click);
            // 
            // frmSistemaGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSistemaGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas de Gestion de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPorCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelDesarrolladorDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeUnaActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeUnBarrioToolStripMenuItem;
    }
}

