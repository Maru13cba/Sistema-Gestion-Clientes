namespace Clientes_Unidad_3
{
    partial class NuevoCliente
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
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtLImNV = new System.Windows.Forms.TextBox();
            this.txtNombreNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAgregarNuevo = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.txtLImNV);
            this.groupBox1.Controls.Add(this.txtNombreNC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(284, 188);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(319, 24);
            this.cmbCiudad.TabIndex = 6;
            // 
            // txtLImNV
            // 
            this.txtLImNV.Location = new System.Drawing.Point(284, 120);
            this.txtLImNV.Name = "txtLImNV";
            this.txtLImNV.Size = new System.Drawing.Size(226, 22);
            this.txtLImNV.TabIndex = 5;
            this.txtLImNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLImNV_KeyPress);
            // 
            // txtNombreNC
            // 
            this.txtNombreNC.Location = new System.Drawing.Point(284, 49);
            this.txtNombreNC.Name = "txtNombreNC";
            this.txtNombreNC.Size = new System.Drawing.Size(319, 22);
            this.txtNombreNC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite de credito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y apellido:";
            // 
            // cmdAgregarNuevo
            // 
            this.cmdAgregarNuevo.Location = new System.Drawing.Point(206, 390);
            this.cmdAgregarNuevo.Name = "cmdAgregarNuevo";
            this.cmdAgregarNuevo.Size = new System.Drawing.Size(152, 30);
            this.cmdAgregarNuevo.TabIndex = 7;
            this.cmdAgregarNuevo.Text = "Agregar Nuevo ";
            this.cmdAgregarNuevo.UseVisualStyleBackColor = true;
            this.cmdAgregarNuevo.Click += new System.EventHandler(this.cmdAgregarNuevo_Click_1);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(490, 390);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(152, 30);
            this.cmdAgregar.TabIndex = 3;
            this.cmdAgregar.Text = "Cargar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            this.cmdAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLImNV_KeyPress);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 471);
            this.Controls.Add(this.cmdAgregarNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "NuevoCliente";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLImNV;
        private System.Windows.Forms.TextBox txtNombreNC;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Button cmdAgregarNuevo;
    }
}