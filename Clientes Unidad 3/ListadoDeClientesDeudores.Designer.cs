namespace Clientes_Unidad_3
{
    partial class ListadoDeClientesDeudores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPromDeudaDeu = new System.Windows.Forms.TextBox();
            this.txtCantidadClieDeudores = new System.Windows.Forms.TextBox();
            this.txtTotalDeuda = new System.Windows.Forms.TextBox();
            this.cmdListarDeudores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaDeudores = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdOredenar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdOredenar);
            this.groupBox1.Controls.Add(this.txtPromDeudaDeu);
            this.groupBox1.Controls.Add(this.txtCantidadClieDeudores);
            this.groupBox1.Controls.Add(this.txtTotalDeuda);
            this.groupBox1.Controls.Add(this.cmdListarDeudores);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GrillaDeudores);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de deusa";
            // 
            // txtPromDeudaDeu
            // 
            this.txtPromDeudaDeu.Location = new System.Drawing.Point(710, 379);
            this.txtPromDeudaDeu.Name = "txtPromDeudaDeu";
            this.txtPromDeudaDeu.Size = new System.Drawing.Size(127, 22);
            this.txtPromDeudaDeu.TabIndex = 7;
            // 
            // txtCantidadClieDeudores
            // 
            this.txtCantidadClieDeudores.Location = new System.Drawing.Point(710, 333);
            this.txtCantidadClieDeudores.Name = "txtCantidadClieDeudores";
            this.txtCantidadClieDeudores.Size = new System.Drawing.Size(127, 22);
            this.txtCantidadClieDeudores.TabIndex = 6;
            // 
            // txtTotalDeuda
            // 
            this.txtTotalDeuda.Location = new System.Drawing.Point(710, 292);
            this.txtTotalDeuda.Name = "txtTotalDeuda";
            this.txtTotalDeuda.Size = new System.Drawing.Size(127, 22);
            this.txtTotalDeuda.TabIndex = 5;
            // 
            // cmdListarDeudores
            // 
            this.cmdListarDeudores.Location = new System.Drawing.Point(689, 430);
            this.cmdListarDeudores.Name = "cmdListarDeudores";
            this.cmdListarDeudores.Size = new System.Drawing.Size(148, 34);
            this.cmdListarDeudores.TabIndex = 4;
            this.cmdListarDeudores.Text = "Listar";
            this.cmdListarDeudores.UseVisualStyleBackColor = true;
            this.cmdListarDeudores.Click += new System.EventHandler(this.cmdListarDeudores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de clientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio de deudas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de deuda:";
            // 
            // GrillaDeudores
            // 
            this.GrillaDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Deuda});
            this.GrillaDeudores.Location = new System.Drawing.Point(15, 39);
            this.GrillaDeudores.Name = "GrillaDeudores";
            this.GrillaDeudores.RowHeadersWidth = 51;
            this.GrillaDeudores.RowTemplate.Height = 24;
            this.GrillaDeudores.Size = new System.Drawing.Size(822, 222);
            this.GrillaDeudores.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 320;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.MinimumWidth = 6;
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 125;
            // 
            // cmdOredenar
            // 
            this.cmdOredenar.Location = new System.Drawing.Point(505, 430);
            this.cmdOredenar.Name = "cmdOredenar";
            this.cmdOredenar.Size = new System.Drawing.Size(145, 34);
            this.cmdOredenar.TabIndex = 9;
            this.cmdOredenar.Text = "Ordenar por deuda";
            this.cmdOredenar.UseVisualStyleBackColor = true;
            this.cmdOredenar.Click += new System.EventHandler(this.cmdOredenar_Click);
            // 
            // ListadoDeClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoDeClientesDeudores";
            this.Text = "ListadoDeClientesDeudores";
            this.Load += new System.EventHandler(this.ListadoDeClientesDeudores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GrillaDeudores;
        private System.Windows.Forms.Button cmdListarDeudores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPromDeudaDeu;
        private System.Windows.Forms.TextBox txtCantidadClieDeudores;
        private System.Windows.Forms.TextBox txtTotalDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Button cmdOredenar;
    }
}