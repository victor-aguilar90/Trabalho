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
        private string password;
        private MySqlConnection connection;

        public BancoDeDados()
        {
            this.server = "localhost";
            this.database = "Petshop";
            this.port = "3306";
            this.password = "";

            Initialize();
        }

        private void Initialize()
        {
            string connectionString = $"Server={server};Database={database};Port={port};Pwd={password};";

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

                this.CloseConnection();
            }
        }


        public void InserirDados(string tableName, string[] columns, object[] values)
        {
            string columnList = string.Join(", ", columns);
            object valueList = string.Join(", ", values);

            string query = $"INSERT INTO {tableName} ({columnList}) VALUES ({valueList})";

            ExecuteQuery(query);
        }
        public void ConsultarDados(string tableName, string[] columns, object[] values)
        {
            string columnList = string.Join(", ", columns);
            object valueList = string.Join(", ", values);

            string query = $"SELECT * FROM {tableName};";
        }
    }
}
