
namespace ControleAbastec;
public class Diesel : Abastecimentos
{
private readonly decimal _bonus = 0m;
public Diesel(string nome, decimal valorAtual, decimal bonus = 0) :
base(nome, valorAtual)
=> _bonus = bonus; }