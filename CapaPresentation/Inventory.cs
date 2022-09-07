using Bussiness;
using Presentation;
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
    public partial class frmInventory : Form
    {
        DataSet inventory;
        ProductsBussiness productsBussiness;
        public frmInventory()
        {
            InitializeComponent();
            productsBussiness = new ProductsBussiness();
        }

        private void btnConsultarI_Click(object sender, EventArgs e)
        {
            int selectedIndex = txtProductI.SelectedIndex;
            var product = inventory.Tables[0].Rows[selectedIndex];

            DataSet data = productsBussiness.GetDataProduct(int.Parse(product["Code"].ToString()));
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = data.Tables["tbl"].TableName;
            dataGridView1.Update();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.ShowDialog();
            this.Close();
        }
    }
}
