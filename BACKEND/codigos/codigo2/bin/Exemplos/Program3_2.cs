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
        MySqlCommand command = new MySqlCommand("SELECT * FROM usuario", connection);
        // Abre a conexão
        connection.Open();
        //O método ExecuteReader retorna um objeto MySqlDataReader que permite iterar sobre os registros retornados pela consulta SQL.
        MySqlDataReader reader = command.ExecuteReader();
        // Iteração sobre os dados
        while (reader.Read())
        {
            int id = reader.GetInt32("id");
            string nome = reader.GetString("nome");
            string sobrenome = reader.GetString("sobrenome");
            string email = reader.GetString("email");
            string senha = reader.GetString("senha");
            
            Console.WriteLine("ID: {0}, Nome: {1} {2}, E-mail: {3}, Senha: {4}", id, nome, sobrenome, email, senha);
        }
        
        reader.Close();
        connection.Close();
        
        Console.WriteLine("Dados lidos da tabela usuario com sucesso!");
    }
}
