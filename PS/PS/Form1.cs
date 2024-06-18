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
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Btn_duvida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senha padrão\nNome:Admin1\nSenha:Senha1");
            Tb_nome.Focus();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string nome = Tb_nome.Text;
            string senha = Tb_senha.Text;

            // Exemplo de lista de funcionários (simulando os funcionários cadastrados)
            List<Funcionario> funcionarios = new List<Funcionario>();

            // Funcionários de exemplo
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

            // Adicionar os funcionários à lista
            funcionarios.Add(novoFuncionario);
            funcionarios.Add(outroFuncionario);

            // Busca o funcionário pelo nome fornecido
            Funcionario funcionarioEncontrado = funcionarios.FirstOrDefault(f => f.NomeFunc == nome);

            // Verifica se encontrou o funcionário e se a senha está correta
            if (funcionarioEncontrado != null && senha == funcionarioEncontrado.SenhaFunc)
            {
                MessageBox.Show($"Login bem sucedido como {funcionarioEncontrado.NomeFunc}.");

                // Aqui você pode decidir qual formulário exibir com base no cargo do funcionário, por exemplo:
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
            }
        }
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
