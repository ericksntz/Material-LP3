namespace ControleAbastec;
public class Diesel_S10 : Abastecimentos
{
public Diesel_S10(string nome, decimal valorAtual) : base(nome, valorAtual)
{
}
public override void ExecutarAjustes()
{
decimal acrescimo = ValorAcumulado * 0.02m;
AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Diesel_S10");
} }