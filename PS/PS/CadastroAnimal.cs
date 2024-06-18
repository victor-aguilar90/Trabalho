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
    public partial class F_CadastroAnimal : Form
    {
        public F_CadastroAnimal()
        {
            InitializeComponent();
        }

        private void Tb_TelefoneCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CodCliente
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tb_CodCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
