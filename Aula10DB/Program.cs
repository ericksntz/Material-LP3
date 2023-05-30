using Microsoft.Data.Sqlite;
using Aula10DB.Database;
using Aula10DB.Repositories;
using Aula10DB.Models;
var databaseConfig = new DatabaseConfig();
var databaseSetup = new DatabaseSetup(databaseConfig);
var clienteRepository = new ClienteRepository(databaseConfig);

var modelName = args[0];
var modelAction = args[1];
if(modelName == "Cliente")
{
    if(modelAction == "List")
    {
        Console.WriteLine("Cliente List");
        foreach (var cliente in clienteRepository.GetAll())
        {
            Console.WriteLine($"{cliente.ClienteId}, {cliente.Endereco}, {cliente.Cidade}, {cliente.Regiao}, {cliente.Pais}, {cliente.Telefone}");
        }
    }

    if(modelAction == "New")
    {
        Console.WriteLine("Cliente New");
        var ClienteId = Convert.ToInt32(args[2]);
        string Endereco = args[60];
        string Cidade = args[32];
        string Regiao = args[10];
        string CodigoPostal = args[16];
        string Pais = args[32];
        string Telefone = args[14];
        var cliente = new Cliente (ClienteId, Endereco, Cidade, Regiao, CodigoPostal, Pais, Telefone);
        clienteRepository.Save(cliente);
    }

    if(modelAction == "Show")
    {
        Console.WriteLine("Cliente Show");
        var id = Convert.ToInt32(args[2]);

        if(clienteRepository.ExitsById(id))
        {
            var cliente = clienteRepository.GetById(id);
            Console.WriteLine($"{cliente.ClienteId}, {cliente.Endereco}, {cliente.Cidade}, {cliente.Regiao}, {cliente.Pais}, {cliente.Telefone}");
        } 
        else 
        {
            Console.WriteLine($"O computador com Id {id} não existe.");
        }
    }
}