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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listadoDeClientesDeusoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeClientesDeudores ventana = new ListadoDeClientesDeudores();

            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Location = new Point(
                this.Location.X + (this.Width - ventana.Width) / 2,
                this.Location.Y + (this.Height - ventana.Height) / 2
            );

            ventana.ShowDialog();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listados_de_Clientes ventana = new Listados_de_Clientes();

            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Location = new Point(
                this.Location.X + (this.Width - ventana.Width) / 2,
                this.Location.Y + (this.Height - ventana.Height) / 2
            );

            ventana.ShowDialog();

        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            BusquedaDeClientes ventana = new BusquedaDeClientes();

            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Location = new Point(
                this.Location.X + (this.Width - ventana.Width) / 2,
                this.Location.Y + (this.Height - ventana.Height) / 2
            );

            ventana.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoCliente ventana = new NuevoCliente();

            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Location = new Point(
                this.Location.X + (this.Width - ventana.Width) / 2,
                this.Location.Y + (this.Height - ventana.Height) / 2
            );

            ventana.ShowDialog();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Listado_PorCiudad ventana = new Listado_PorCiudad();

            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Location = new Point(
                this.Location.X + (this.Width - ventana.Width) / 2,
                this.Location.Y + (this.Height - ventana.Height) / 2
            );

            ventana.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "";
            BackColor = Color.FromArgb(240, 248, 255);
            menuStrip1.BackColor = Color.FromArgb(33, 150, 243); // azul celeste fuerte
            menuStrip1.ForeColor = Color.White;

            lblTitulo.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(21, 101, 192);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitulo.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(80, 80, 80);

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void aCercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_cerca_del_sistema ventana = new A_cerca_del_sistema();

            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Location = new Point(
                this.Location.X + (this.Width - ventana.Width) / 2,
                this.Location.Y + (this.Height - ventana.Height) / 2
            );

            ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
