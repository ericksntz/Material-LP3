namespace ControleAbastec;
public class Diesel_S8 : Abastecimentos
{
public Diesel_S8(string nome, decimal valorAtual) : base(nome, valorAtual)
{
}
public override void ExecutarAjustes()
{
decimal acrescimo = ValorAcumulado * 0.03m;
AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Diesel_S8");
} }