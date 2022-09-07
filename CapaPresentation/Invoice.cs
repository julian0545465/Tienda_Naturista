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
        public frmInvoice()
        {
            InitializeComponent();
            sellerBussiness = new SellerBussiness();
            productsBussiness = new ProductsBussiness();
            clientBussiness = new ClientBussiness();
        }

       

        private void frmInvoice_Load(object sender, EventArgs e)
        {

            seller = sellerBussiness.GetData();

            comboBoxVendedor.DataSource = seller.Tables[0];
            comboBoxVendedor.DisplayMember = "IdEmployee";

            seller = clientBussiness.GetData();

            txtClientF.DataSource = seller.Tables[0];
            txtClientF.DisplayMember = "Name";

            seller = productsBussiness.GetData();

            txtProductF.DataSource = seller.Tables[0];
            txtProductF.DisplayMember = "Description";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtClientF.Text != " " && txtProductF.Text != " " && comboBoxVendedor.Text != " " && txtQuantityF.Text != " " && dateTimePicker1.Text != "")
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = comboBoxVendedor.Text;
                row.Cells[1].Value = txtClientF.Text;
                row.Cells[2].Value = txtProductF.Text;
                row.Cells[3].Value = txtQuantityF.Text;
                row.Cells[4].Value = dateTimePicker1.Text;
                dataGridView1.Rows.Add(row);
            }
            //Invoice invoice = new Invoice();
            //Products products = new Products();

            //invoice.Code = Convert.ToInt32(txtProductF.SelectedValue.ToString());
            //products.Description = txtProductF.Text;
            //String Cantidad = txtQuantityF.Text;
            //products.Value = productsBussiness.ConsultValue;
            //DataFact.Rows.Add(claseEntidad.Codigo, claseEntidad.Producto, Cantidad, claseEntidad.Valor);
            //int NumeroFilas = DataFact.Rows.Count;
            //int ValorTotal = 0;
            //if (NumeroFilas > 1)
            //{
            //    for (int i = 0; i < (NumeroFilas - 1); i++)
            //    {
            //        int Can = Convert.ToInt16(DataFact.Rows[i].Cells[2].Value.ToString());
            //        int Val = Convert.ToInt16(DataFact.Rows[i].Cells[3].Value.ToString());
            //        ValorTotal += Can * Val;
            //    }
            //    TXTTotal.Text = ValorTotal.ToString();
            //}
            //else
            //{
            //    TXTTotal.Text = claseEntidad.Valor.ToString();
            //}
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}

