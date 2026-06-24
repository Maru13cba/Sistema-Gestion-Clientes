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
    public partial class Listado_PorCiudad : Form
    {
        public Listado_PorCiudad()
        {
            InitializeComponent();
        }

        private void Listado_PorCiudad_Load(object sender, EventArgs e)
        {
            ClsCiudad x = new ClsCiudad();
            x.Listar(cmbCiudad);

            this.Text = "Listado de Clientes por Ciudad";
            this.BackColor = Color.FromArgb(240, 248, 255);

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.ForeColor = Color.FromArgb(21, 101, 192);
                    control.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                if (control is Label)
                {
                    control.ForeColor = Color.FromArgb(21, 101, 192);
                }
            }

            dgvClientesCiudad.BackgroundColor = Color.White;
            dgvClientesCiudad.GridColor = Color.LightGray;

            dgvClientesCiudad.EnableHeadersVisualStyles = false;
            dgvClientesCiudad.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvClientesCiudad.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientesCiudad.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvClientesCiudad.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvClientesCiudad.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 249, 255);

            dgvClientesCiudad.RowHeadersVisible = false;
            dgvClientesCiudad.AllowUserToAddRows = false;
            dgvClientesCiudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientesCiudad.MultiSelect = false;
            dgvClientesCiudad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientesCiudad.ColumnHeadersHeight = 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 idCiu = Convert.ToInt32(cmbCiudad.SelectedValue);
            ClsCliente x = new ClsCliente();
            x.ListarClientesDeUnaCiudad(dgvClientesCiudad, idCiu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 idCiu = Convert.ToInt32(cmbCiudad.SelectedValue);
            ClsCliente x = new ClsCliente();
            x.ReporteClientesDeCiudad(idCiu);
            MessageBox.Show("Archivo generado exitosamente");
        }
    }
}
