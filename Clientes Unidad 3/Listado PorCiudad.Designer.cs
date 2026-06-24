namespace Clientes_Unidad_3
{
    partial class Listado_PorCiudad
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
            this.dgvClientesCiudad = new System.Windows.Forms.DataGridView();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmdGenerarReporteCiu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdListarCiu = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesCiudad
            // 
            this.dgvClientesCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvClientesCiudad.Location = new System.Drawing.Point(57, 86);
            this.dgvClientesCiudad.Name = "dgvClientesCiudad";
            this.dgvClientesCiudad.RowHeadersWidth = 51;
            this.dgvClientesCiudad.RowTemplate.Height = 24;
            this.dgvClientesCiudad.Size = new System.Drawing.Size(760, 269);
            this.dgvClientesCiudad.TabIndex = 0;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(147, 32);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(670, 24);
            this.cmbCiudad.TabIndex = 1;
            // 
            // cmdGenerarReporteCiu
            // 
            this.cmdGenerarReporteCiu.Location = new System.Drawing.Point(381, 400);
            this.cmdGenerarReporteCiu.Name = "cmdGenerarReporteCiu";
            this.cmdGenerarReporteCiu.Size = new System.Drawing.Size(153, 41);
            this.cmdGenerarReporteCiu.TabIndex = 2;
            this.cmdGenerarReporteCiu.Text = "Generar Reporte";
            this.cmdGenerarReporteCiu.UseVisualStyleBackColor = true;
            this.cmdGenerarReporteCiu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ciudades:";
            // 
            // cmdListarCiu
            // 
            this.cmdListarCiu.Location = new System.Drawing.Point(664, 400);
            this.cmdListarCiu.Name = "cmdListarCiu";
            this.cmdListarCiu.Size = new System.Drawing.Size(153, 41);
            this.cmdListarCiu.TabIndex = 4;
            this.cmdListarCiu.Text = "Listar";
            this.cmdListarCiu.UseVisualStyleBackColor = true;
            this.cmdListarCiu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 500;
            // 
            // Listado_PorCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.cmdListarCiu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGenerarReporteCiu);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.dgvClientesCiudad);
            this.Name = "Listado_PorCiudad";
            this.Text = "Listado_PorCiudad";
            this.Load += new System.EventHandler(this.Listado_PorCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Button cmdGenerarReporteCiu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdListarCiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}