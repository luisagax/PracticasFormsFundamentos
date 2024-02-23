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
    public partial class frmCompras : Form
    {
        string[,] ArticulosCompra = new string[4,4];
        public frmCompras(string[,] Articulo)
        {
            InitializeComponent();
            ArticulosCompra = Articulo;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                libSubtotal.Items.Add(ArticulosCompra[i, 0]);
        }
    }
}
