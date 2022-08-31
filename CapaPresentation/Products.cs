using Bussiness;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmProducts : Form
    {
        ProductsBussiness productsBussiness;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void ingresarProductoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pnlInsert.Visible = true;
            pnlModify.Visible = false;
            pnlConsultProduct.Visible = false;
            pnlDelete.Visible = false;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsert.Visible = false;
            pnlModify.Visible = false;
            pnlConsultProduct.Visible = true;
            pnlDelete.Visible = false;

        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsert.Visible = false;
            pnlModify.Visible = true;
            pnlConsultProduct.Visible = false;
            pnlDelete.Visible = false;

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsert.Visible = false;
            pnlModify.Visible = false;
            pnlConsultProduct.Visible = false;
            pnlDelete.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            productsBussiness = new ProductsBussiness();
            if (txtCode.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el codigo del producto");
            }
            else if (txtDescription.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la descripcion del producto");
            }
            else if (txtValue.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el valor del producto");
            }
            else if (txtQuantity.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la cantidad del producto");
            }
            else
            {
                Products products = new Products();
                products.Code = int.Parse(txtCode.Text);
                products.Description = txtDescription.Text;
                products.Value = int.Parse(txtValue.Text);
                products.Quantity = int.Parse(txtQuantity.Text);
                bool login = productsBussiness.InsertProduct(products);

            }
        }
    }
}
