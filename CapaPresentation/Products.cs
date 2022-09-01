using Bussiness;
using DataAccess;
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
        Connection connection;
        ProductsBussiness productsBussiness;
        DataSet products;
        public frmProducts()
        {
            InitializeComponent();
            productsBussiness = new ProductsBussiness();
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
            connection = new Connection();
            productsBussiness = new ProductsBussiness();

            pnlInsert.Visible = false;
            pnlModify.Visible = false;
            pnlConsultProduct.Visible = true;
            pnlDelete.Visible = false;


            products = productsBussiness.GetData();

            txtSearchP.DataSource = products.Tables[0];
            txtSearchP.ValueMember = "Code";
            txtSearchP.DisplayMember = "Description";

        }



        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsert.Visible = false;
            pnlModify.Visible = true;
            pnlConsultProduct.Visible = false;
            pnlDelete.Visible = false;

            LoadModificarConmbo();



        }

        public void LoadModificarConmbo()
        {
            products = productsBussiness.GetData();

            comboBox1.DataSource = products.Tables[0];
            comboBox1.ValueMember = "Code";
            comboBox1.DisplayMember = "Description";
        }
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsert.Visible = false;
            pnlModify.Visible = false;
            pnlConsultProduct.Visible = false;
            pnlDelete.Visible = true;

            loadComboDelete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

                if (login)
                {
                    MessageBox.Show("Registro Guardado");
                    CleanForm();
                }
                else
                {
                    MessageBox.Show("Registro no Guardado");
                }
            }
        }
        public void CleanForm()
        {
            txtCode.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtValue.Text = string.Empty;
            txtQuantity.Text = string.Empty;

        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {

            int selectedIndex = txtSearchP.SelectedIndex;
            var product = products.Tables[0].Rows[selectedIndex];

            DataSet data = productsBussiness.GetDataProduct(int.Parse(product["Code"].ToString()));
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = data.Tables["tbl"].TableName;
            dataGridView1.Update();

        }

        private void btnConsultM_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            var product = products.Tables[0].Rows[selectedIndex];

            DataSet data = productsBussiness.GetDataProduct(int.Parse(product["Code"].ToString()));
            if (data.Tables[0].Rows.Count > 0)
            {
                txtCantidadM.Text = data.Tables[0].Rows[0]["Quantity"].ToString();
                txtDescriptionM.Text = data.Tables[0].Rows[0]["Description"].ToString();
                txtValueM.Text = data.Tables[0].Rows[0]["Value"].ToString();
            }
        }

        public void loadComboDelete()
        {
            products = productsBussiness.GetData();

            comboBox2.DataSource = products.Tables[0];
            comboBox2.ValueMember = "Code";
            comboBox2.DisplayMember = "Description";
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (txtDescriptionM.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la descripcion del producto");
            }
            else if (txtValueM.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el valor del producto");
            }
            else if (txtCantidadM.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la cantidad del producto");
            }
            else
            {
                int selectedIndex = comboBox1.SelectedIndex;
                var productSelected = products.Tables[0].Rows[selectedIndex];


                Products product = new Products();
                product.Code = int.Parse(productSelected["Code"].ToString());
                product.Quantity = int.Parse(txtCantidadM.Text);
                product.Description = txtDescriptionM.Text;
                product.Value = int.Parse(txtValueM.Text);
                bool update = productsBussiness.UpdateProduct(product);

                if (update)
                {
                    MessageBox.Show("Registro Actualizado");
                    LoadModificarConmbo();
                    txtDescriptionM.Text = String.Empty;
                    txtValueM.Text = String.Empty;
                    txtCantidadM.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Registro no Actualizado");
                }
            }
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            int selectedIndex = comboBox1.SelectedIndex;
            var productSelected = products.Tables[0].Rows[selectedIndex];

      
            bool remove = productsBussiness.DeleteProduct(int.Parse(productSelected["Code"].ToString()));
          
            if (remove)
            {
                loadComboDelete();
                MessageBox.Show("Registro Eliminado");
            }
            else
            {
                MessageBox.Show("Registro no Eliminado");
            }
        }

       
    }
}
