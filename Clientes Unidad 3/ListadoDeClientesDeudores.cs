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
    public partial class ListadoDeClientesDeudores : Form
    {
        public ListadoDeClientesDeudores()
        {
            InitializeComponent();
        }

        private void cmdListarDeudores_Click(object sender, EventArgs e)
        {
            ClsCliente x = new ClsCliente();
            x.ListarClientesDeudores(GrillaDeudores);

            txtTotalDeuda.Text= x.TotalDeuda.ToString();
            txtCantidadClieDeudores.Text = x.CantidadDeudores.ToString("0.00");
            txtPromDeudaDeu.Text=x.PromedioDeuda.ToString("0.00");
        }

        private bool OrdenDescendente = true;
        private void cmdOredenar_Click(object sender, EventArgs e)
        {

            if (OrdenDescendente)
            {
                GrillaDeudores.Sort(
                    GrillaDeudores.Columns[2],
                    ListSortDirection.Descending);

                cmdOredenar.Text = "Ordenar menor a mayor";

                OrdenDescendente = false;
            }
            else
            {
                GrillaDeudores.Sort(
                    GrillaDeudores.Columns[2],
                    ListSortDirection.Ascending);

                cmdOredenar.Text = "Ordenar mayor a menor";

                OrdenDescendente = true;
            }
        }

        private void ListadoDeClientesDeudores_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de Clientes Deudores";
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
            GrillaDeudores.BackgroundColor = Color.White;
            GrillaDeudores.GridColor = Color.LightGray;

            GrillaDeudores.EnableHeadersVisualStyles = false;

            GrillaDeudores.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(33, 150, 243);

            GrillaDeudores.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            GrillaDeudores.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            GrillaDeudores.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            GrillaDeudores.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 249, 255);

            GrillaDeudores.RowHeadersVisible = false;
            GrillaDeudores.AllowUserToAddRows = false;

            GrillaDeudores.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            GrillaDeudores.MultiSelect = false;

            GrillaDeudores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            GrillaDeudores.ColumnHeadersHeight = 45;

            // Resultados
            txtTotalDeuda.ReadOnly = true;
            txtCantidadClieDeudores.ReadOnly = true;
            txtPromDeudaDeu.ReadOnly = true;

            txtTotalDeuda.BackColor = Color.White;
            txtCantidadClieDeudores.BackColor = Color.White;
            txtPromDeudaDeu.BackColor = Color.White;

            txtTotalDeuda.TextAlign = HorizontalAlignment.Right;
            txtCantidadClieDeudores.TextAlign = HorizontalAlignment.Right;
            txtPromDeudaDeu.TextAlign = HorizontalAlignment.Right;
        }
    }
}
