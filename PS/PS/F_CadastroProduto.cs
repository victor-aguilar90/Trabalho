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
    public partial class F_CadastroProduto : Form
    {

        private BancoDeDados db;
        public F_CadastroProduto()
        {
            InitializeComponent();
            db = new BancoDeDados();
        }

        private void Tb_TelefoneFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tb_QuantidadeDeProduto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void F_CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeP = NomeProduto.Text;
            double preco = double.Parse(PrecoP.Text);
            int qtd = int.Parse(QtdP.Text);
            string desc = DescP.Text;

            if (preco >= 0 && qtd < 0) 
            {
                MessageBox.Show("Erro!");
            }

            string[] colunas = { "nome_produto", "descricao", "preco_produto", "quantidade" };
            object[] valores = { nomeP, desc, preco, qtd};

            try
            {
                db.InserirDados("produto", colunas, valores);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dados: {ex.Message}");
            }

            string query = "SELECT * FROM produto";

            DataTable dados = db.ConsultarDados(query);

            dataGridView1.DataSource = dados;

            NomeProduto.Text = string.Empty;
            PrecoP.Text = string.Empty;
            QtdP.Text = string.Empty;
            DescP.Text = string.Empty;


        }
    }
}
