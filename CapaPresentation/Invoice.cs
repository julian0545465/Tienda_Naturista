using Bussiness;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Presentation;

namespace PresentationLayer
{
    public partial class frmInvoice : Form
    {
        Connection connection;
        SellerBussiness sellerBussiness;
        ClientBussiness clientBussiness;
        ProductsBussiness productsBussiness;
        DataSet seller;
        DataSet products= new DataSet();
        public frmInvoice()
        {
            InitializeComponent();
            sellerBussiness = new SellerBussiness();
            productsBussiness = new ProductsBussiness();
            clientBussiness = new ClientBussiness();
            products.Tables.Add("products");
            products.Tables[0].Columns.Add("Code");
            products.Tables[0].Columns.Add("Name");
            products.Tables[0].Columns.Add("Quantity");
        }



        private void frmInvoice_Load(object sender, EventArgs e)
        {
            txtQuantityF.Text = "1";
            seller = sellerBussiness.GetData();

            comboBoxVendedor.DataSource = seller.Tables[0];
            comboBoxVendedor.DisplayMember = "User";
            comboBoxVendedor.ValueMember = "IdEmployee";


            seller = clientBussiness.GetData();

            txtClientF.DataSource = seller.Tables[0];
            txtClientF.DisplayMember = "Name";
            txtClientF.ValueMember = "Document";


            seller = productsBussiness.GetData();

            txtProductF.DataSource = seller.Tables[0];
            txtProductF.DisplayMember = "Description";
            txtProductF.ValueMember = "Code";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Invoice invoice = new Invoice();
            Products products = new Products();
            InvoiceBussiness invoiceBussiness = new InvoiceBussiness();
            products.Code = Convert.ToInt32(txtProductF.SelectedValue.ToString());
            products.Description = txtProductF.Text;
            String Cantidad = txtQuantityF.Text;
            products.Value = invoiceBussiness.PriceInvoice(products.Code);
            dataGridView2.Rows.Add(products.Code, products.Description, Cantidad, products.Value);
            int NumeroFilas = dataGridView2.Rows.Count;
            int ValorTotal = 0;
            if (NumeroFilas > 1)
            {
                for (int i = 0; i < (NumeroFilas - 1); i++)
                {
                    int Can = Convert.ToInt16(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    int Val = Convert.ToInt16(dataGridView2.Rows[i].Cells[3].Value.ToString());
                    ValorTotal += Can * Val;
                }
                txtTotal.Text = ValorTotal.ToString();
            }
            else
            {
                txtTotal.Text = products.Value.ToString();
            }

        }

        //int selectedIndex = txtProductF.SelectedIndex;
        //var product = products.Tables[0].Rows[selectedIndex];

        //DataSet data = productsBussiness.GetDataProduct(int.Parse(product["Code"].ToString()));

        //dataGridView1.Columns.Add("Code", "Código");
        //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
        //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
        //    row.Cells[0].Value = comboBoxVendedor.Text;
        //    row.Cells[1].Value = txtClientF.Text;
        //    row.Cells[2].Value = txtProductF.Text;
        //    row.Cells[3].Value = txtQuantityF.Text;
        //    row.Cells[4].Value = dateTimePicker1.Text;
        //    dataGridView1.Rows.Add(row);

        //data.Tables[0].Columns
        //products.Tables[0].Rows.Add( );
        //product.Table
        //products.Tables[0].Rows.
        //DataSet data = productsBussiness.GetDataProduct(int.Parse(this.products["Code"].ToString()));
        //dataGridView1.DataSource = data;
        //dataGridView1.DataMember = data.Tables["tbl"].TableName;
        //dataGridView1.Update();



        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }     
    }
}

