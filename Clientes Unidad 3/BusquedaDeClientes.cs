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
    public partial class BusquedaDeClientes : Form
    {
        public BusquedaDeClientes()
        {
            InitializeComponent();

            Limpiar();
            cmdBuscar.Enabled = false;
        }


        private void Limpiar()
        {
            txtCodigoCliente.Text = "";
            txtNombreBC.Text = "";
            txtDeudaBC.Text = "";
            txtLimCredBC.Text = "";

            txtNombreBC.ReadOnly = true;
            txtDeudaBC.ReadOnly = true;
            txtLimCredBC.ReadOnly = true;

            cmdBuscar.Enabled = false;
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;

            txtCodigoCliente.Enabled = true;

            txtCodigoCliente.Focus();
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            cmdBuscar.Enabled = int.TryParse(txtCodigoCliente.Text, out _);
        }


        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdCliente = Convert.ToInt32(txtCodigoCliente.Text);
            ClsCliente xBC = new ClsCliente();
            xBC.Buscar(IdCliente);

            if (xBC.idCliente != 0)
            {
                txtNombreBC.Text = xBC.Nombre;
                txtDeudaBC.Text = xBC.Deuda.ToString();
                txtLimCredBC.Text = xBC.Limite.ToString();

                txtLimCredBC.ReadOnly = true;

                cmdEliminar.Enabled = true;
                cmdModificar.Enabled = true;
                cmdGuardar.Enabled = false;
            }
            else
            {
                txtNombreBC.Text = "";
                txtDeudaBC.Text = "";
                txtLimCredBC.Text = "";

                cmdEliminar.Enabled = false;
                cmdModificar.Enabled = false;
                cmdGuardar.Enabled = false;

                MessageBox.Show("Cliente no encontrado");
            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtLimCredBC.Text, out decimal limite))
            {
                MessageBox.Show("El límite de crédito debe ser numérico.");
                return;
            }

            Int32 id = Convert.ToInt32(txtCodigoCliente.Text);

            ClsCliente cli = new ClsCliente();
            cli.Limite = limite;
            cli.Modificar(id);

            MessageBox.Show("Datos guardados exitosamente");

            Limpiar();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            txtNombreBC.ReadOnly = true;
            txtDeudaBC.ReadOnly = true;
            txtLimCredBC.ReadOnly = false;

            txtCodigoCliente.Enabled = false;
            cmdBuscar.Enabled = false;

            cmdGuardar.Enabled = true;
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;

            txtLimCredBC.Focus();

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigoCliente.Text);

            ClsCliente cli = new ClsCliente();
            cli.Eliminar(id);

            MessageBox.Show("Dato Eliminado exitosamente");

            Limpiar();
        }

        private void BusquedaDeClientes_Load(object sender, EventArgs e)
        {
            this.Text = "Búsqueda de Clientes";
            this.BackColor = Color.FromArgb(240, 248, 255);

            groupBox1.ForeColor = Color.FromArgb(21, 101, 192);
            groupBox2.ForeColor = Color.FromArgb(21, 101, 192);
        }

        //para admitir solo números en Código
        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El código del cliente solo admite números.");
            }
        }

      
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigoCliente.Focus();
        }

     
    }
}
