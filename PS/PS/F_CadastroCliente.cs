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
            string telC = TelefoneCli.Text;
            string endC = EnderecoCli.Text;

            if (string.IsNullOrEmpty(nomeC) && string.IsNullOrEmpty(emailC) && string.IsNullOrEmpty(endC))
            {
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

        private void TelefoneCli_TextChanged(object sender, EventArgs e)
        {
            string digitsOnly = new string(TelefoneCli.Text.Where(char.IsDigit).ToArray());

            if (digitsOnly.Length > 0)
            {
                if (digitsOnly.Length <= 2)
                {
                    TelefoneCli.Text = string.Format("({0}", digitsOnly);
                }
                else if (digitsOnly.Length <= 6)
                {
                    TelefoneCli.Text = string.Format("({0}) {1}", digitsOnly.Substring(0, 2), digitsOnly.Substring(2));
                }
                else if (digitsOnly.Length <= 10)
                {
                    TelefoneCli.Text = string.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 2), digitsOnly.Substring(2, 4), digitsOnly.Substring(6));
                }
                else
                {
                    TelefoneCli.Text = string.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 2), digitsOnly.Substring(2, 4), digitsOnly.Substring(6, 4));
                }
            }

            // Move o cursor para o final do texto
            TelefoneCli.SelectionStart = TelefoneCli.Text.Length;
        }
    }
}