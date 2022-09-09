using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmproducts = new frmProducts();
            frmproducts.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice frminvoce = new frmInvoice();
            frminvoce.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory frminventory = new frmInventory();
            frminventory.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient frmclient = new frmClient();
            frmclient.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.ShowDialog();
        }
    }
}
