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
        public frmClient()
        {
            InitializeComponent();
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

        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertClient.Visible = false;
            pnlConsultClient.Visible = false;
            pnlModifyClient.Visible = true;
            pnlDeleteCli.Visible = false;
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlInsertClient.Visible = false;
            pnlConsultClient.Visible = false;
            pnlModifyClient.Visible = false;
            pnlDeleteCli.Visible = true;
        }
    }
}
