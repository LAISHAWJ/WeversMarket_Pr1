using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeversMarket_p1
{
    public partial class FormProduc : Form
    {
        public FormProduc()
        {
            InitializeComponent();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.Hide();
            formPrincipal.Show();
        }
    }
}
