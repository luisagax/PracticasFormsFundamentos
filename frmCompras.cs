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
            //for (int i = 0; i < 4; i++)
            //    libSubtotal.Items.Add(ArticulosCompra[i, 0]);
        }

        private void txtIndice_Leave(object sender, EventArgs e)
        {
        }

        private void txtArt_Leave(object sender, EventArgs e)
        {
            int indice = 10;
            int cont = 0;
            int x = 0;

            foreach(string art in ArticulosCompra)
            {
                if(art == txtArt.Text)
                {
                    indice = cont;
                    break;
                }
                cont++;
                if (cont == 4)
                {
                    x++;
                    cont = 0;
                }
            }
            lbPrecio.Text = ArticulosCompra[x, 1];
            txtIndice.Text = indice.ToString();
        }
    }
}
