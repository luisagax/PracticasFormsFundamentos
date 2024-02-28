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
            //int indice = 10;
            //int Columna = 0;
            //int Fila = 0;

            //foreach (string art in ArticulosCompra)
            //{
            //    if (art == txtArt.Text)
            //    {
            //        indice = Columna;
            //        break;
            //    }
            //    Columna++;
            //    if (Columna == 4)
            //    {
            //        Fila++;
            //        Columna = 0;
            //    }
            //}
            //lbPrecio.Text = ArticulosCompra[Fila, 1];
            //txtIndice.Text = indice.ToString();

            int i = 0;
            for (i = 0; i < 4; i++)
            {
                if(ArticulosCompra[i, 0] == txtArt.Text)
                {
                    lbPrecio.Text = $"${ArticulosCompra[i, 1]}";
                    
                }
            }
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (ArticulosCompra[i, 0] == txtArt.Text)
                {
                    if (txtCant.Text != "")
                    {
                        //Aqui se guarda la cantidad en el indice 2
                        ArticulosCompra[i, 2] = txtCant.Text;
                        ArticulosCompra[i, 3] = (double.Parse(ArticulosCompra[i, 1]) * double.Parse(ArticulosCompra[i, 2])).ToString();
                        lblTotal.Items.Add($"{ArticulosCompra[i, 0]} - $ {ArticulosCompra[i, 1]} - Cant. {ArticulosCompra[i, 2]} - Total. $ {ArticulosCompra[i, 3]}");
                    }
                }
            }
        }
    }
}
