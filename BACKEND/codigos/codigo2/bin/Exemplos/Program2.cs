using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Informações de conexão com o banco de dados
        string connectionString = "server=localhost;database=erp;uid=root;password=root;";
        // Cria conexão com banco de dados
        MySqlConnection connection = new MySqlConnection(connectionString);
        // Passa o comando para a execução comando no banco de dados
        MySqlCommand command = new MySqlCommand("CREATE TABLE usuario (id INT AUTO_INCREMENT PRIMARY KEY, nome VARCHAR(50) NOT NULL, sobrenome VARCHAR(50) NOT NULL, email VARCHAR(50) NOT NULL, senha VARCHAR(50) NOT NULL)", connection);
        // Abre a conexão
        connection.Open();
        // Executa comandos no SGBD que não retornam dados
        command.ExecuteNonQuery();
        // Fecha a conexão
        connection.Close();
        
        Console.WriteLine("Tabela usuario criada com sucesso!");
    }
}
