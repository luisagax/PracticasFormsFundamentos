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
        public string[,] Ticket = new string[4, 4];
        int cont = 0;
        public frmTicketVenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Si el contador es menor a 4 el código se ejecutará, si no mandará un mensaje
            if (cont < 4)
            {
                //Agregar los valores de las cajas de texto a las variables
                string Articulo = txtArticulo.Text;
                string Precio = txtPrecio.Text;
                //Agregar valores al arreglo
                Ticket[cont, 0] = Articulo;
                Ticket[cont, 1] = Precio;
                //Se agrega a un ListBox el articulo y precio
                libArticulos.Items.Add($"{Articulo}   ${Precio}");
                //Incrementar el contador
                cont++;
                //Limpia las cajas de texto
                txtArticulo.Clear();
                txtPrecio.Clear();
                //Se enfoca en la la caja de texto de articulos
                txtArticulo.Focus();
            }
            else
                MessageBox.Show("Solo se pueden agregar 4 artículos.");
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {

        }

        private void frmTicketVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
