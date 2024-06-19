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
        }

        private void REcadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeF = Tb_NomeFunc.Text;
            string emailF = Tb_EmailFunc.Text;
            int telF = int.Parse(Tb_TelefoneFunc.Text);
            string senhaF = Tb_SenhaFunc.Text;
            int codF = int.Parse(Tb_CodFunc.Text);

            string[] colunas = { "nome_func", "sal_func", "email_func", "telefone_func", "cod_cargo" };
            object[] valores = { nomeF, "", emailF, telF, "" };

            try
            {
                db.AtualizarDados("funcionarip", colunas, valores, "Id", codF);
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar dados: {ex.Message}");
            }


        }
    }
}
