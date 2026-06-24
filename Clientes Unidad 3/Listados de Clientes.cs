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
    public partial class Listados_de_Clientes : Form
    {
        public Listados_de_Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            ClsCliente objClienete = new ClsCliente();
            objClienete.ListarClientes(Grilla);
            txtCantidadClientes.Text = objClienete.CantidadDeudores.ToString();
            txtTotalDeDeuda.Text = objClienete.TotalDeuda.ToString("0.00");
            txtPromedioDeuda.Text = objClienete.PromedioDeuda.ToString ("0.00");

            cmdGenerarReporte.Enabled = true;
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            ClsCliente objClienete = new ClsCliente();
            objClienete.ReporteClientes();
            MessageBox.Show("Reporte generado exitosamente!");
        }

        private void Listados_de_Clientes_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de Clientes";
            this.BackColor = Color.FromArgb(240, 248, 255);

            groupBox1.ForeColor = Color.FromArgb(21, 101, 192);

            // Botones
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.ForeColor = Color.FromArgb(21, 101, 192);
                    control.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }

            // Diseño de la grilla
            Grilla.BackgroundColor = Color.White;
            Grilla.GridColor = Color.LightGray;

            Grilla.EnableHeadersVisualStyles = false;

            Grilla.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(33, 150, 243);

            Grilla.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            Grilla.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            Grilla.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            Grilla.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 249, 255);

            Grilla.RowHeadersVisible = false;
            Grilla.AllowUserToAddRows = false;
            Grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla.MultiSelect = false;

            Grilla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Grilla.ColumnHeadersHeight = 45;

            // Campos de resultados
            txtTotalDeDeuda.ReadOnly = true;
            txtCantidadClientes.ReadOnly = true;
            txtPromedioDeuda.ReadOnly = true;

            txtTotalDeDeuda.BackColor = Color.White;
            txtCantidadClientes.BackColor = Color.White;
            txtPromedioDeuda.BackColor = Color.White;

            txtTotalDeDeuda.TextAlign = HorizontalAlignment.Right;
            txtCantidadClientes.TextAlign = HorizontalAlignment.Right;
            txtPromedioDeuda.TextAlign = HorizontalAlignment.Right;
        }

        //declaración de var 
        private bool OrdenDescendente = true;
        private void cmdOredenar_Click(object sender, EventArgs e)
        {

            if (OrdenDescendente)
            {
                Grilla.Sort(Grilla.Columns[4], ListSortDirection.Descending);
                OrdenDescendente = false;
            }
            else
            {
                Grilla.Sort(Grilla.Columns[4], ListSortDirection.Ascending);
                OrdenDescendente = true;
            }
        }
    }
}
