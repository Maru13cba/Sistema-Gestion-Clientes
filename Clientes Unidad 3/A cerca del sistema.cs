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
    public partial class A_cerca_del_sistema : Form
    {
        public A_cerca_del_sistema()
        {
            InitializeComponent();
        }

        private void A_cerca_del_sistema_Load(object sender, EventArgs e)
        {
            this.Text = "Acerca del sistema";
            this.BackColor = Color.FromArgb(240, 248, 255);

            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                    control.ForeColor = Color.FromArgb(40, 40, 40);
                }
            }
        }
    }
}
