using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS
{
    public class Modelos { 
        public class Cargo { public int CodCargo; public string NomeCargo; }
        public class Funcionario { public int CodFunc; public string NomeFunc; public string EmailFunc; public string TelefoneFunc; public string SenhaFunc; public int CodCargo; }
        public class Cliente { public int CodCliente; public string NomeCli; public string TelefoneCli; public string Email; public string Endereco; }
        public class Animal { public int CodAnimal; public string NomeAnimal; public string Tipo; public int CodCliente; }
        public class Produto { public int CodProduto; public string NomeProduto; public string Descricao; public decimal PrecoProduto; public int Quantidade; }
        public class Venda { public int CodVendas; public DateTime DataVenda; public int CodCli; public decimal Total; public int CodFunc; }
        public class ItemVenda { public int CodItensVendas; public int CodVendas; public int CodProduto; public decimal Preco; }
        public class Servico { public int CodServico; public string NomeServico; public string Descricao; public decimal PrecoServico; }
        public class Agendamento { public int CodAgendamento; public DateTime DataAgendamento; public TimeSpan HoraAgendamento; public int CodCli; public int CodAnimal; public int CodServico; public int CodFunc; public string Status; }
    }
}
