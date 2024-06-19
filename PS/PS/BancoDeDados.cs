using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace PS
{
    public class BancoDeDados
    {
        private string server;
        private string database;
        private string port;
        private string user;
        private string password;
        private MySqlConnection connection;

        public BancoDeDados()
        {
            this.server = "localhost";
            this.database = "Petshop";
            this.port = "3306";
            this.user = "root";
            this.password = "";

            Initialize();
        }

        private void Initialize()
        {
            string connectionString = $"Server={server};Database={database};Port={port};User={user};Password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com MySQL aberta com sucesso!");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão com MySQL: {ex.Message}");
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexão com MySQL fechada com sucesso!");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao fechar a conexão com MySQL: {ex.Message}");
                return false;
            }
        }

        public void ExecuteQuery(string query)
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao executar a consulta SQL: {ex.Message}");
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public void InserirDados(string tabela, string[] colunas, object[] valores)
        {
            if (colunas.Length != valores.Length)
            {
                throw new ArgumentException("O número de colunas deve corresponder ao número de valores.");
            }

            string columnList = string.Join(", ", colunas);
            string parameterList = string.Join(", ", colunas.Select(col => "@" + col));
            string query = $"INSERT INTO {tabela} ({columnList}) VALUES ({parameterList})";

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                for (int i = 0; i < colunas.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + colunas[i], valores[i]);
                }

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao executar a consulta SQL: {ex.Message}");
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public DataTable ConsultarDados(string query)
        {
            DataTable dataTable = new DataTable();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao consultar dados: {ex.Message}");
                }
                finally
                {
                    this.CloseConnection();
                }
            }

            return dataTable;
        }

        public void AtualizarDados(string tabela, string[] colunas, object[] valores, string condicaoColuna, object condicaoValor)
        {
            if (colunas.Length != valores.Length)
            {
                throw new ArgumentException("O número de colunas deve corresponder ao número de valores.");
            }

            string setClause = string.Join(", ", colunas.Select(col => $"{col} = @{col}"));
            string query = $"UPDATE {tabela} SET {setClause} WHERE {condicaoColuna} = @condicaoValor";

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                for (int i = 0; i < colunas.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + colunas[i], valores[i]);
                }

                cmd.Parameters.AddWithValue("@conditionValue", condicaoValor);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao executar a consulta SQL: {ex.Message}");
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public DataTable ConsultaEspecifica(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao consultar dados: {ex.Message}");
                }
                finally
                {
                    this.CloseConnection();
                }
            }

            return dataTable;
        }
    }
}