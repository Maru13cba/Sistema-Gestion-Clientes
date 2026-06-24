namespace Clientes_Unidad_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCercaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeusoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesOrdenadosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCercaDelSistemaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemasToolStripMenuItem.Image")));
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // aCercaDelSistemaToolStripMenuItem
            // 
            this.aCercaDelSistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aCercaDelSistemaToolStripMenuItem.Image")));
            this.aCercaDelSistemaToolStripMenuItem.Name = "aCercaDelSistemaToolStripMenuItem";
            this.aCercaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aCercaDelSistemaToolStripMenuItem.Text = "A cerca del sistema";
            this.aCercaDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.aCercaDelSistemaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.buscarClientesToolStripMenuItem,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeClientesDeusoresToolStripMenuItem,
            this.listadoDeClientesOrdenadosPorToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarNuevosClientesToolStripMenuItem.Image")));
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarClientesToolStripMenuItem.Image")));
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.buscarClientesToolStripMenuItem.Text = "Buscar clientes";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listadoDeTodosLosClientesToolStripMenuItem.Image")));
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeusoresToolStripMenuItem
            // 
            this.listadoDeClientesDeusoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listadoDeClientesDeusoresToolStripMenuItem.Image")));
            this.listadoDeClientesDeusoresToolStripMenuItem.Name = "listadoDeClientesDeusoresToolStripMenuItem";
            this.listadoDeClientesDeusoresToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.listadoDeClientesDeusoresToolStripMenuItem.Text = "Listado de clientes deudores";
            this.listadoDeClientesDeusoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeusoresToolStripMenuItem_Click);
            // 
            // listadoDeClientesOrdenadosPorToolStripMenuItem
            // 
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listadoDeClientesOrdenadosPorToolStripMenuItem.Image")));
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Name = "listadoDeClientesOrdenadosPorToolStripMenuItem";
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Text = "Listado de clientes por ciudad";
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesOrdenadosPorToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(691, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Gestión de Clientes";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(765, 153);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(289, 16);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Administración, consultas y reportes de clientes";
            this.lblSubtitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 536);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCercaDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeusoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesOrdenadosPorToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}

