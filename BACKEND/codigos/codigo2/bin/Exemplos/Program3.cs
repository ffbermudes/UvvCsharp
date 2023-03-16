using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Informações de conexão com o banco de dados
        string connectionString = "server=localhost;database=erp;uid=root;password=root;";
        // Cria conexão com banco de dados
        MySqlConnection connection = new MySqlConnection(connectionString);;
        // Passa o comando para a execução comando no banco de dados
        MySqlCommand command = new MySqlCommand("INSERT INTO usuario (nome, sobrenome, email, senha) VALUES ('Fulano', 'Silva', 'fulano@email.com', '123456')", connection);
        // Abre a conexão
        connection.Open();
        // Executa comandos no SGBD que não retornam dados
        command.ExecuteNonQuery();
        // Fecha a conexão
        connection.Close();
        
        Console.WriteLine("Dados inseridos na tabela usuario com sucesso!");
    }
}
