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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void BtProduc_Click(object sender, EventArgs e)
        {
            FormProduc formProduc = new FormProduc();
            this.Hide();
            formProduc.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            DialogResult Opcionsalir = MessageBox.Show("¿Estás seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (Opcionsalir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
