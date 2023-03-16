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
        MySqlCommand command = new MySqlCommand("UPDATE usuario SET nome = 'Ciclano', sobrenome = 'Silva' WHERE id = 1", connection);
        // Abre a conexão
        connection.Open();
        // Executa comandos no SGBD que não retornam dados
        command.ExecuteNonQuery();
        // Fecha a conexão
        connection.Close();
        
        Console.WriteLine("Dados atualizados na tabela usuario com sucesso!");
    }
}
