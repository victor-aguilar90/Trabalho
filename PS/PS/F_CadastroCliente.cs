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
    public partial class F_CadastroCliente : Form
    {
        private BancoDeDados db;
        public F_CadastroCliente()
        {
            InitializeComponent();
            db = new BancoDeDados();
        }

        private void F_CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeC = NomeCli.Text;
            string emailC = EmailCli.Text;
            int telC = int.Parse(TelefoneCli.Text);
            string endC = EnderecoCli.Text;

            if(string.IsNullOrEmpty(nomeC) && string.IsNullOrEmpty(emailC) && string.IsNullOrEmpty(endC)) {
                MessageBox.Show("Erro!");
            }

            string[] colunas = { "nome_cli", "telefone_cli", "email", "endereco" };
            object[] valores = { nomeC, telC, emailC, endC };

            try
            {
                db.InserirDados("cliente", colunas, valores);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dados: {ex.Message}");
            }

            string query = "SELECT * FROM cliente";



            DataTable dados = db.ConsultarDados(query);
            dataGridView1.DataSource = dados;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
