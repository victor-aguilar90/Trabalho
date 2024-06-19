using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using static PS.Modelos;

namespace PS
{
    public partial class F_CadastroFunc : Form
    {

        private BancoDeDados db;

        public F_CadastroFunc()
        {
            InitializeComponent();
            db = new BancoDeDados();
            CarregarFuncionarios();
        }

        private void F_CadastroFunc_Load(object sender, EventArgs e)
        {

        }

        private void Lb_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
        }

        private void Tb_TelefoneFunc_TextChanged(object sender, EventArgs e)
        {
            //Parte legal de comentar
            string digitsOnly = new string(Tb_TelefoneFunc.Text.Where(char.IsDigit).ToArray());
            //Cria a variavel digitsOnly recebe nova string, que á TextBox.Text verifica se é número e transforma em um array

            if (digitsOnly.Length > 0)
            {
                if (digitsOnly.Length <= 2)
                {
                    Tb_TelefoneFunc.Text = string.Format("({0}", digitsOnly);
                }
                else if (digitsOnly.Length <= 6)
                {
                    Tb_TelefoneFunc.Text = string.Format("({0}) {1}", digitsOnly.Substring(0, 2), digitsOnly.Substring(2));
                }
                else if (digitsOnly.Length <= 10)
                {
                    Tb_TelefoneFunc.Text = string.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 2), digitsOnly.Substring(2, 4), digitsOnly.Substring(6));
                }
                else
                {
                    Tb_TelefoneFunc.Text = string.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 2), digitsOnly.Substring(2, 4), digitsOnly.Substring(6, 4));
                }
            }
            //digitsOnly.Substring(x, y) é um metodo que mostra aonde inicia na a formadação da string e quantos digitos você pode fazer
            Tb_TelefoneFunc.SelectionStart = Tb_TelefoneFunc.Text.Length;
        }

        private void Tb_TelefoneFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Tb_SenhaFunc.Text == Tb_VerificacaoSenha.Text)
            {
                MessageBox.Show("Funcionou");
            }
            else
            {
                MessageBox.Show("Senha não compativel");
            }

            /*Funcionario funcionario = new Funcionario();
            Tb_NomeFunc.Text = funcionario.NomeFunc;
            Tb_SenhaFunc.Text = funcionario.SenhaFunc;
            Tb_EmailFunc.Text = funcionario.EmailFunc;
            Tb_TelefoneFunc.Text = funcionario.TelefoneFunc;*/

            string nomeF = Tb_NomeFunc.Text;
            string emailF = Tb_EmailFunc.Text;
            string telF = Tb_TelefoneFunc.Text;
            string senhaF = Tb_SenhaFunc.Text;
            string cargoF = Cargo.Text;

            if (FuncionarioExists(nomeF))
            {
                MessageBox.Show("Já existe um funcionário com este nome cadastrado.");
                return;
            }

            string[] colunas = { "nome_func", "email_func", "senha_func", "telefone_func", "cargo_func" };
            object[] valores = { nomeF, emailF, senhaF, telF, cargoF };

            try
            {
                db.InserirDados("funcionario", colunas, valores);
                CarregarFuncionarios();
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir dados: {ex.Message}");
            }

        }

        private bool FuncionarioExists(string nomeFunc)
        {
            string query = $"SELECT COUNT(*) FROM funcionario WHERE nome_func = '{nomeFunc}'";
            DataTable resultado = db.ConsultarDados(query);
            return Convert.ToInt32(resultado.Rows[0][0]) > 0;
        }

        private void Btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (Tb_SenhaFunc.UseSystemPasswordChar == true)
            {
                Tb_SenhaFunc.UseSystemPasswordChar = false;
                Tb_VerificacaoSenha.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_SenhaFunc.UseSystemPasswordChar = true;
                Tb_VerificacaoSenha.UseSystemPasswordChar = true;
            }
        }

        private void cadastroClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_CadastroCliente f_CadastroCliente = new F_CadastroCliente();
            f_CadastroCliente.ShowDialog();
        }

        private void cadastroAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadastroAnimal f_CadastroAnimal = new F_CadastroAnimal();
            f_CadastroAnimal.ShowDialog();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEcadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REcadastroFuncionario rEcadastroFuncionario = new REcadastroFuncionario();
            rEcadastroFuncionario.ShowDialog();
        }

        private void Cb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadastroProduto f_CadastroProduto = new F_CadastroProduto();
            f_CadastroProduto.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComprarProduto f_ComprarProduto = new F_ComprarProduto();
            f_ComprarProduto.ShowDialog();
        }

        private void cadastroAgendamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Agendamento f_Agendamento = new F_Agendamento();
            f_Agendamento.ShowDialog();
        }
        private void CarregarFuncionarios()
        {
            string query = "SELECT cod_func AS 'Código', nome_func AS 'Nome', IFNULL(email_func, 'Não informado') AS 'Email', IFNULL(telefone_func, 'Não informado') AS 'Telefone' FROM funcionario";
            DataTable dtFuncionarios = db.ConsultarDados(query);

            Dg_Func.DataSource = null;

            Dg_Func.DataSource = dtFuncionarios;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}