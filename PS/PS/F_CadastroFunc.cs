using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PS.Modelos;

namespace PS
{
    public partial class F_CadastroFunc : Form
    {
        public F_CadastroFunc()
        {
            InitializeComponent();
            //BancoDeDados bd = new BancoDeDados();
            //Dg_Func.DataSource = bd.ExecutarConsultaDataTabble("Select * from funcionario"); 
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

            Funcionario funcionario = new Funcionario();
            Tb_NomeFunc.Text = funcionario.NomeFunc;
            Tb_SenhaFunc.Text = funcionario.SenhaFunc;
            Tb_EmailFunc.Text = funcionario.EmailFunc;
            Tb_TelefoneFunc.Text = funcionario.TelefoneFunc;

            string tabela = "funcionario";
            string[] colunas = { "nome_func", "email_func", "telefone_func", "senha_func" };
            object[] valores = { funcionario.NomeFunc, funcionario.EmailFunc, funcionario.TelefoneFunc, funcionario.SenhaFunc };

            BancoDeDados conexao = new BancoDeDados();

            conexao.InserirDados(tabela, colunas, valores);
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
            F_CadastroProduto f_CadastroProduto = new F_CadastroProduto();
            f_CadastroProduto.ShowDialog();
        }

        private void cadastroAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Agendamento f_Agendamento = new F_Agendamento();
            f_Agendamento.ShowDialog();
        }

        private void rEcadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REcadastroFuncionario rEcadastroFuncionario = new REcadastroFuncionario();
            rEcadastroFuncionario.ShowDialog();
        }
    }
}
