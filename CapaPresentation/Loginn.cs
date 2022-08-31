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
    public partial class Loginn : Form
    {
        EmployeeBussiness employeeBussiness;
        public Loginn()
        {
            InitializeComponent();
            employeeBussiness = new EmployeeBussiness();
        }

      

        private void btnGet_Click(object sender, EventArgs e)
        {

            if (txtUsser.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar usuario");
            }
            else if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar contraseña");
            }
            else
            {
                Employee employee = new Employee();
                employee.User = txtUsser.Text;
                employee.Password = txtPassword.Text;
                bool login = employeeBussiness.SelectEmployee(employee);

                if (login)
                {
                

                    MainMenu menu = new MainMenu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Usuario y/o Contraseña incorrectas 😤 ");

            }
        }


    }
}