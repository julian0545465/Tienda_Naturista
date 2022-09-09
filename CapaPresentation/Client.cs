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

namespace Presentation
{
    public partial class frmClient : Form
    {
        ClientBussiness clientBussiness;
        DataSet client;
        public frmClient()
        {
            InitializeComponent();
            clientBussiness = new ClientBussiness();

            pnlInsertClient.Visible = false;
            pnlConsultClient.Visible = false;
            pnlModifyClient.Visible = false;
            pnlDeleteCli.Visible = false;

        }


        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertClient.Visible = true;
            pnlConsultClient.Visible = false;
            pnlModifyClient.Visible = false;
            pnlDeleteCli.Visible = false;
            
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertClient.Visible = false;
            pnlConsultClient.Visible = true;
            pnlModifyClient.Visible = false;
            pnlDeleteCli.Visible = false;

            client = clientBussiness.GetData();

            txtSearchC.DataSource = client.Tables[0];
            txtSearchC.ValueMember = "Document";
            txtSearchC.DisplayMember = "Name";

        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertClient.Visible = false;
            pnlConsultClient.Visible = false;
            pnlModifyClient.Visible = true;
            pnlDeleteCli.Visible = false;
            LoadModificarConmbo();
        }
        public void LoadModificarConmbo()
        {
            client = clientBussiness.GetData();

            comboBoxModify.DataSource = client.Tables[0];
            comboBoxModify.ValueMember = "Document";
            comboBoxModify.DisplayMember = "Name";
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertClient.Visible = false;
            pnlConsultClient.Visible = false;
            pnlModifyClient.Visible = false;
            pnlDeleteCli.Visible = true;
            loadComboDelete();
        }
        public void loadComboDelete()
        {
            client = clientBussiness.GetData();

            comboBoxDelete.DataSource = client.Tables[0];
            comboBoxDelete.ValueMember = "Document";
            comboBoxDelete.DisplayMember = "Name";
        }


        private void btnSaveCli_Click(object sender, EventArgs e)
        {
            if (txtDocument.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el documento del cliente");
            }
            else if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del cliente");
            }
            else if (txtAddress.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la direccion del cliente");
            }
            else if (txtNumberphone.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el numero de telefono del cliente");
            }
            //else if(txtEmail.Text == String.Empty) 
            //{
            //    MessageBox.Show("Debe ingresar el correo electronico del cliente");
            //}
            else
            {
                Client client = new Client();
                client.Document = int.Parse(txtDocument.Text);
                client.Name = txtName.Text;
                client.Address = txtAddress.Text;
                client.Numberphone = int.Parse(txtNumberphone.Text);
                client.Email = txtEmail.Text;
                bool save = clientBussiness.InsertClient(client);

                if (save)
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
            txtDocument.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNumberphone.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }

        private void btnCleanCli_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnConsultCliC_Click(object sender, EventArgs e)
        {
            int selectedIndex = txtSearchC.SelectedIndex;
            var clients = client.Tables[0].Rows[selectedIndex];

            DataSet data = clientBussiness.GetDataClient(int.Parse(clients["Document"].ToString()));
            dataGridViewCli.DataSource = data;
            dataGridViewCli.DataMember = data.Tables["tbl"].TableName;
            dataGridViewCli.Update();
        }

        private void btnConsultCliM_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxModify.SelectedIndex;
            var clients = client.Tables[0].Rows[selectedIndex];

            DataSet data = clientBussiness.GetDataClient(int.Parse(clients["Document"].ToString()));
            if (data.Tables[0].Rows.Count > 0)
            {
                txtNameCliM.Text = data.Tables[0].Rows[0]["Name"].ToString();
                txtAddressCliM.Text = data.Tables[0].Rows[0]["Address"].ToString();
                txtNumberphoneCliM.Text = data.Tables[0].Rows[0]["Numberphone"].ToString();
                txtEmailCliM.Text = data.Tables[0].Rows[0]["Email"].ToString();
            }
        }

        private void btnSaveChangeCliM_Click(object sender, EventArgs e)
        {
           
            if (txtNameCliM.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del cliente");
            }
            else if (txtAddressCliM.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la direccion del cliente");
            }
            else if (txtNumberphoneCliM.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el numero de telefono del cliente");
            }
            //else if(txtEmailCliM.Text == String.Empty) 
            //{
            //    MessageBox.Show("Debe ingresar el correo electronico del cliente");
            //}
            else
            {
                int selectedIndex = comboBoxModify.SelectedIndex;
                var clientSelected = client.Tables[0].Rows[selectedIndex];


                Client clients = new Client();
                clients.Document = int.Parse(clientSelected["Document"].ToString());
                clients.Name = txtNameCliM.Text;
                clients.Address = txtAddressCliM.Text;
                clients.Numberphone = int.Parse(txtNumberphoneCliM.Text);
                clients.Email = txtEmailCliM.Text;
                bool updateclient = clientBussiness.UpdateClient(clients);

                if (updateclient)
                {
                    MessageBox.Show("Registro Actualizado");
                    
                    LoadModificarConmbo();
                    txtNameCliM.Text = String.Empty;
                    txtAddressCliM.Text = String.Empty;
                    txtNumberphoneCliM.Text = String.Empty;
                    txtEmailCliM.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Registro no Actualizado");
                }
            }
        }


        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            Client clients = new Client();
            int selectedIndex = comboBoxModify.SelectedIndex;
            var clientSelected = client.Tables[0].Rows[selectedIndex];

            bool removeclient = clientBussiness.DeleteClient(int.Parse(clientSelected["Document"].ToString()));

            if (removeclient)
            {
                loadComboDelete();
                MessageBox.Show("Registro Eliminado");
            }
            else
            {
                MessageBox.Show("Registro no Eliminado");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
    }
}

