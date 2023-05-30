
using Aula10DB.Database;
using Aula10DB.Models;
using Microsoft.Data.Sqlite;
namespace Aula10DB.Repositories;
class ClienteRepository
{
    private readonly DatabaseConfig _databaseConfig;
    public ClienteRepository(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }

    public List<Cliente> GetAll()
    {
        var clientes = new List<Cliente>();
        

        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Clientes";

        var reader = command.ExecuteReader();

        while(reader.Read())
        {
            var ClienteId = reader.GetInt32(0);
            var Endereco= reader.GetString(1);
            var Cidade = reader.GetString(2);
            var Regiao = reader.GetString(3);
            var Pais = reader.GetString(4);
            var Telefone = reader.GetString(5);
            var cliente = ReaderToCliente(reader);
            clientes.Add(cliente);
        }

        connection.Close();
        
        return clientes;
    }

    public Cliente GetById(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Clientes WHERE (id = $id)";
        command.Parameters.AddWithValue("$id", id);

        var reader = command.ExecuteReader();
        reader.Read();

        var cliente = ReaderToCliente(reader);

        connection.Close(); 

        return cliente;
    }
    
    public bool ExitsById(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT count(id) FROM Clientes WHERE (id = $id)";
        command.Parameters.AddWithValue("$id", id);

        var reader = command.ExecuteReader();
        reader.Read();
        var result = reader.GetBoolean(0);

        return result;
    }
private Cliente ReaderToCliente(SqliteDataReader reader)
    {
        var cliente = new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));

        return cliente;
    }
}