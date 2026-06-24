using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes_Unidad_3
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            ClsCiudad ciu = new ClsCiudad();
            ciu.Listar (cmbCiudad);

            this.Text = "Nuevo Cliente";
            this.BackColor = Color.FromArgb(240, 248, 255);

            groupBox1.ForeColor = Color.FromArgb(21, 101, 192);

            cmdAgregar.Enabled = false;
            cmdAgregarNuevo.Enabled = false;

            txtNombreNC.TextChanged += ValidarCampos;
            txtLImNV.TextChanged += ValidarCampos;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreNC.Text.Trim() == "" || txtLImNV.Text.Trim() == "")
            {
                MessageBox.Show("Debe cargar nombre y límite de crédito.");
                return;
            }

            if (!decimal.TryParse(txtLImNV.Text, out decimal limite))
            {
                MessageBox.Show("El límite de crédito debe ser solo numérico.");
                return;
            }

            ClsCliente cliNuev = new ClsCliente();
            cliNuev.Nombre = txtNombreNC.Text;
            cliNuev.Limite = limite;
            cliNuev.idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            cliNuev.AgregarClienete();

            MessageBox.Show("Cliente cargado");

            txtNombreNC.Text = "";
            txtLImNV.Text = "";
            cmbCiudad.SelectedIndex = 0;

        }

        private void cmdAgregarNuevo_Click_1(object sender, EventArgs e)
        {
            ClsCliente cli = new ClsCliente();
            cli.Nombre = txtNombreNC.Text;
            cli.Limite = Convert.ToDecimal(txtLImNV.Text);
            cli.idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);

            cli.AgregarNuevoRegistro();
            MessageBox.Show("NuevoCliente cliente agregado");

            txtNombreNC.Text = "";
            txtLImNV.Text = "";
            cmbCiudad.SelectedIndex = 0;
        }

        //Se agrega validación de datos para que no permita cargar sin datos:

        private void ValidarCampos(object sender, EventArgs e)
        {
            bool nombreValido = txtNombreNC.Text.Trim().Length >= 3;
            bool limiteValido = txtLImNV.Text.Trim().Length >= 3;

            cmdAgregar.Enabled = nombreValido && limiteValido;
            cmdAgregarNuevo.Enabled = nombreValido && limiteValido;
        }

      

        private void txtLImNV_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!char.IsControl(e.KeyChar) &&
          !char.IsDigit(e.KeyChar) &&
          e.KeyChar != ',')
          {
             e.Handled = true;
             MessageBox.Show("Solo se permiten números en el límite de crédito.");
          }
        }
    }
}
