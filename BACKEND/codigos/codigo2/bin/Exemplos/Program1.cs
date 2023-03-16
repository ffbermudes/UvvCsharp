using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Informações de conexão com o banco de dados
        string connectionString = "server=localhost;uid=root;password=root;";
        // Cria conexão com banco de dados
        MySqlConnection connection = new MySqlConnection(connectionString);
        // Passa o comando para a execução comando no banco de dados
        MySqlCommand command = new MySqlCommand("CREATE DATABASE ERP", connection);
        // Abre a conexão
        connection.Open();
        // executa comandos no SGBD que não retornam dados
        command.ExecuteNonQuery();
        // Fecha a conexão
        connection.Close();
        
        Console.WriteLine("Banco de dados criado com sucesso!");
    }
}
