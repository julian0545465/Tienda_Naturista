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
        InventoryBussiness inventoryBussiness;
        public frmInventory()
        {
            InitializeComponent();
            inventoryBussiness = new InventoryBussiness();
        }

        private void btnConsultarI_Click(object sender, EventArgs e)
        {

            int selectedIndex = txtProductI.SelectedIndex;
            var inven = inventory.Tables[0].Rows[selectedIndex];

            DataSet data = inventoryBussiness.GetDataProduct(int.Parse(inven["Code"].ToString()));
            dataGridViewIn.DataSource = data;
            dataGridViewIn.DataMember = data.Tables["tbl"].TableName;
            dataGridViewIn.Update();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.ShowDialog();
            this.Close();
        }
    }
}
