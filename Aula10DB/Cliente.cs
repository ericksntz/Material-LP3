namespace Aula10DB.Models;

class Cliente
{
public int ClienteId { get; set; }
public string Endereco { get; set; }
public string Cidade { get; set; }
public string Regiao { get; set; }
public string CodigoPostal { get; set; }
public string Pais { get; set; }
public string Telefone { get; set; }

    public Cliente(int Clienteid, string Endereco, string Cidade, string Regiao, string CodigoPostal, string Pais, string Telefone)
    {
        ClienteId = Clienteid;
        Endereco = Endereco;
        Cidade = Cidade;
        Regiao = Regiao;
        CodigoPostal = CodigoPostal;
        Pais = Pais;
        Telefone = Telefone;
    }
}
