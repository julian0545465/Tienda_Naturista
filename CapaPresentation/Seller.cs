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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }
        private void btnReturnS_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();

        }

        private void btnSaveSeller_Click(object sender, EventArgs e)
        {
            if (txtIdSeller.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el Id del empleado");
            }
            else if (txtUsserSeller.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el Usuario del empleado");
            }
            else if (txtPasswordSeller.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar la contraseña del empleado");
            }
            else
            {
                SellerBussiness sellerBussiness = new SellerBussiness();
                Employee employee = new Employee();
                employee.Id = int.Parse(txtIdSeller.Text);
                employee.User = txtUsserSeller.Text;
                employee.Password = txtPasswordSeller.Text;

                bool save = sellerBussiness.InsertSeller(employee);

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
            txtIdSeller.Text = string.Empty;
            txtUsserSeller.Text = string.Empty;
            txtPasswordSeller.Text = string.Empty;


        }

        private void btnCleanSeller_Click(object sender, EventArgs e)
        {
            CleanForm();
        }
    }
}

