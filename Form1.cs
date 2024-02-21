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
    public partial class frmTicketVenta : Form
    {
        string[,] Ticket = new string[4, 4];
        int cont = 0;
        public frmTicketVenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar los valores de las cajas de texto a las variables
            string Articulo = txtArticulo.Text;
            string Precio = txtPrecio.Text;
            //Agregar valores al arreglo
            Ticket[cont, 0] = Articulo;
            Ticket[cont, 1] = Precio;
            //Incrementar el contador
            cont++;
            //Manda mensaje que el articulo fue agregado
            MessageBox.Show("Articulo agregado.");
            //Limpia las cajas de texto
            txtArticulo.Clear();
            txtPrecio.Clear();
            //Se enfoca en la la caja de texto de articulos
            txtArticulo.Focus();
        }
    }
}
