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
    public partial class F_Principal : Form
    {
        private BancoDeDados db;
        public F_Principal()
        {
            InitializeComponent();
            db = new BancoDeDados();
        }
        //Este é um botão criado para que se a primeira vez que usuario esteja usando este sistema, assim ele concerteza pode entrar
        private void Btn_duvida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senha padrão\nNome:Admin1\nSenha:Senha1");
            Tb_nome.Focus();
        }
        //Botão de entrada//Devemos vincular com o banco para conseguir acessar
        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string nome = Tb_nome.Text;
            string senha = Tb_senha.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, insira o nome de usuário e a senha.");
                Tb_nome.Focus();
                return;
            }

            string query = "SELECT nome_func, senha_func FROM funcionario WHERE nome_func = @nome AND senha_func = @senha";

            var parameters = new Dictionary<string, object>
            {
                { "@nome", nome},
                { "@senha", senha }
            };

            try
            {
                DataTable resultado = db.ConsultaEspecifica(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    string nomeF = resultado.Rows[0]["nome_func"].ToString();
                    string senhaF = resultado.Rows[0]["senha_func"].ToString();

                    if (senha == senhaF && nome == nomeF)
                    {
                        MessageBox.Show("Usuario e Senha corretos!");
                        F_CadastroFunc f_CadastroFunc = new F_CadastroFunc();
                        f_CadastroFunc.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Usuário e Senha incorretos.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e senha não encontrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar dados: {ex.Message}");
            }
        }

        /*List<Funcionario> funcionarios = new List<Funcionario>();

        Funcionario novoFuncionario = new Funcionario();
        novoFuncionario.NomeFunc = "Admin1";
        novoFuncionario.EmailFunc = "Admin1@example.com";
        novoFuncionario.TelefoneFunc = "(11) 9999-8888";
        novoFuncionario.SenhaFunc = "Senha1";
        novoFuncionario.CodCargo = 1;

        Funcionario outroFuncionario = new Funcionario();
        outroFuncionario.NomeFunc = "Felipy";
        outroFuncionario.EmailFunc = "FelipyPeixe@gmail.com";
        outroFuncionario.TelefoneFunc = "(11) 9999-8888";
        outroFuncionario.SenhaFunc = "Peixe";
        outroFuncionario.CodCargo = 1;

        funcionarios.Add(novoFuncionario);
        funcionarios.Add(outroFuncionario);

        Funcionario funcionarioEncontrado = funcionarios.FirstOrDefault(f => f.NomeFunc == nome);

        if (funcionarioEncontrado != null && senha == funcionarioEncontrado.SenhaFunc)
        {
            MessageBox.Show($"Login bem sucedido como {funcionarioEncontrado.NomeFunc}.");

            if (funcionarioEncontrado.NomeFunc == "Admin1")
            {
                REcadastroFuncionario rEcadastroFuncionario = new REcadastroFuncionario();
                rEcadastroFuncionario.ShowDialog();
            }
            else
            {
                F_CadastroFunc f_CadastroFunc = new F_CadastroFunc();
                f_CadastroFunc.ShowDialog();
            }
        }
        else
        {
            MessageBox.Show("Falha no login.\nVerifique a senha e o nome do usuário.");
        }*/// Uma funcionalidade simples para conseguir vizualizar sua senha, para ter certeza que está digitando certo

        private void Btn_visualizar_Click(object sender, EventArgs e)
        {
            if (Tb_senha.UseSystemPasswordChar == true)
            {
                Tb_senha.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_senha.UseSystemPasswordChar = true;
            }
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}