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
        private BancoDeDados db;
        public F_CadastroAnimal()
        {
            InitializeComponent();

            db = new BancoDeDados();
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

        private void F_CadastroAnimal_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = NomeAnimal.Text;
            string raca = RacaAnimal.Text;
            int codC = int.Parse(CodCli.Text);

            string[] colunas = { "nome_animal", "tipo", "cod_cliente"};
            object[] valores = { nome, raca, codC };

            try
            {
                db.InserirDados("animal", colunas, valores);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dados: {ex.Message}");
            }

            string query = "SELECT * FROM animal";

            DataTable dados = db.ConsultarDados(query);

            dataGridView1.DataSource = dados;

            /*NomeAnimal.Text = string.Empty;
            RacaAnimal.Text = string.Empty;
            CodCli.Text = string.Empty;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
