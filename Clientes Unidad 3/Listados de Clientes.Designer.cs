namespace Clientes_Unidad_3
{
    partial class Listados_de_Clientes
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
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.cmdOredenar = new System.Windows.Forms.Button();
            this.txtTotalDeDeuda = new System.Windows.Forms.TextBox();
            this.txtPromedioDeuda = new System.Windows.Forms.TextBox();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.Grilla.Location = new System.Drawing.Point(0, 36);
            this.Grilla.Name = "Grilla";
            this.Grilla.RowHeadersWidth = 51;
            this.Grilla.RowTemplate.Height = 24;
            this.Grilla.Size = new System.Drawing.Size(852, 226);
            this.Grilla.TabIndex = 0;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código de cliente";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ciudad del cliente";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de deuda";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Deuda";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdListar);
            this.groupBox1.Controls.Add(this.cmdGenerarReporte);
            this.groupBox1.Controls.Add(this.cmdOredenar);
            this.groupBox1.Controls.Add(this.txtTotalDeDeuda);
            this.groupBox1.Controls.Add(this.txtPromedioDeuda);
            this.groupBox1.Controls.Add(this.txtCantidadClientes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Grilla);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos ";
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(704, 419);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(144, 34);
            this.cmdListar.TabIndex = 11;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.Location = new System.Drawing.Point(496, 419);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(172, 34);
            this.cmdGenerarReporte.TabIndex = 10;
            this.cmdGenerarReporte.Text = "Generar reporte";
            this.cmdGenerarReporte.UseVisualStyleBackColor = true;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            // 
            // cmdOredenar
            // 
            this.cmdOredenar.Location = new System.Drawing.Point(311, 419);
            this.cmdOredenar.Name = "cmdOredenar";
            this.cmdOredenar.Size = new System.Drawing.Size(145, 34);
            this.cmdOredenar.TabIndex = 8;
            this.cmdOredenar.Text = "Ordenar por deuda";
            this.cmdOredenar.UseVisualStyleBackColor = true;
            this.cmdOredenar.Click += new System.EventHandler(this.cmdOredenar_Click);
            // 
            // txtTotalDeDeuda
            // 
            this.txtTotalDeDeuda.Location = new System.Drawing.Point(749, 273);
            this.txtTotalDeDeuda.Name = "txtTotalDeDeuda";
            this.txtTotalDeDeuda.ReadOnly = true;
            this.txtTotalDeDeuda.Size = new System.Drawing.Size(100, 22);
            this.txtTotalDeDeuda.TabIndex = 7;
            // 
            // txtPromedioDeuda
            // 
            this.txtPromedioDeuda.Location = new System.Drawing.Point(749, 360);
            this.txtPromedioDeuda.Name = "txtPromedioDeuda";
            this.txtPromedioDeuda.ReadOnly = true;
            this.txtPromedioDeuda.Size = new System.Drawing.Size(100, 22);
            this.txtPromedioDeuda.TabIndex = 6;
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Location = new System.Drawing.Point(749, 318);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.ReadOnly = true;
            this.txtCantidadClientes.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadClientes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promedio de deudas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de clientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de deuda:";
            // 
            // Listados_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 475);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listados_de_Clientes";
            this.Text = "Listados_de_Clientes";
            this.Load += new System.EventHandler(this.Listados_de_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPromedioDeuda;
        private System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.Button cmdOredenar;
        private System.Windows.Forms.TextBox txtTotalDeDeuda;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdGenerarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}