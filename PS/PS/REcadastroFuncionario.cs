using MySql.Data.MySqlClient;
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
    public partial class REcadastroFuncionario : Form
    {
        private BancoDeDados db;
        public REcadastroFuncionario()
        {
            InitializeComponent();
            db = new BancoDeDados();
            CarregarFuncionarios();
        }

        private void REcadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeF = Tb_NomeFunc.Text;
            string emailF = Tb_EmailFunc.Text;
            string telF = Tb_TelefoneFunc.Text;
            string senhaF = Tb_SenhaFunc.Text;
            int codCargo = Tb_CodFunc.Text == "Gerente" ? 1 : Tb_CodFunc.Text == "Atendente" ? 2 : 0;

            if (FuncionarioExists(nomeF))
            {
                MessageBox.Show("Já existe um funcionário com este nome cadastrado.");
                return;
            }

            string[] colunas = { "nome_func", "email_func", "telefone_func", "cod_cargo" };
            object[] valores = { nomeF, emailF, telF, codCargo };

            try
            {
                db.AtualizarDados("funcionario", colunas, valores, "Id", codCargo);
                CarregarFuncionarios();
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar dados: {ex.Message}");
            }


        }

        private void Tb_TelefoneFunc_TextChanged(object sender, EventArgs e)
        {
            string digitsOnly = new string(Tb_TelefoneFunc.Text.Where(char.IsDigit).ToArray());

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

            Tb_TelefoneFunc.SelectionStart = Tb_TelefoneFunc.Text.Length;
        }

        private void Tb_CodFunc_TextChanged(object sender, EventArgs e)
        {
            string codFuncStr = Tb_CodFunc.Text.Trim();
            if (!string.IsNullOrEmpty(codFuncStr) && int.TryParse(codFuncStr, out int codFunc))
            {
             ConsultarFuncionarioPorCodigo(codFunc);
            }
        }
        private bool FuncionarioExists(string nomeFunc)
        {
            string query = $"SELECT COUNT(*) FROM funcionario WHERE nome_func = '{nomeFunc}'";
            DataTable resultado = db.ConsultarDados(query);
            return Convert.ToInt32(resultado.Rows[0][0]) > 0;
        }
        private void ConsultarFuncionarioPorCodigo(int codFunc)
        {
            string query = "SELECT nome_func, email_func, telefone_func, cod_cargo FROM funcionario WHERE cod_func = @CodFunc";
            DataTable dt = db.ConsultarDados(query);
            if (dt.Rows.Count > 0)
            {
                Tb_NomeFunc.Text = dt.Rows[0]["nome_func"].ToString();
                Tb_EmailFunc.Text = dt.Rows[0]["email_func"].ToString();
                Tb_TelefoneFunc.Text = dt.Rows[0]["telefone_func"].ToString();

                int codigoCargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);

                Cb_Cargo.SelectedValue = codigoCargo;

                switch (codigoCargo)
                {
                    case 1:
                        Cb_Cargo.SelectedItem = "Gerente";
                        break;
                    case 2:
                        Cb_Cargo.SelectedItem = "Atendente";
                        break;
                    default:
                        Cb_Cargo.SelectedItem = "Outro";
                        break;
                }
            }
        }
        private void CarregarFuncionarios()
        {
            string query = "SELECT cod_func AS 'Código', nome_func AS 'Nome', IFNULL(email_func, 'Não informado') AS 'Email', IFNULL(telefone_func, 'Não informado') AS 'Telefone' FROM funcionario";
            DataTable dtFuncionarios = db.ConsultarDados(query);

            Dg_Func.DataSource = null;

            Dg_Func.DataSource = dtFuncionarios;
        }
    }
}
