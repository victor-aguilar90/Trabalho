using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS
{
    public partial class F_ComprarProduto : Form
    {
        public F_ComprarProduto()
        {
            InitializeComponent();
        }

        private void F_ComprarProduto_Load(object sender, EventArgs e)
        {

        }

        private void Tb_CodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tb_qtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_qtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
