using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketDeVentaP1
{
    public partial class frmMenu : Form
    {
        string[,] Articulos = new string[4,4];
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsbArticulos_Click(object sender, EventArgs e)
        {
            frmTicketVenta a = new frmTicketVenta();
            Articulos = a.Ticket;
            a.ShowDialog();
        }

        private void tsbCantidad_Click(object sender, EventArgs e)
        {
            if (Articulos[0, 0] == null)
            {
                MessageBox.Show("No ha agregado ningún articulo");
            }
            else
            {
                frmCompras a = new frmCompras(Articulos);
                a.ShowDialog();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
