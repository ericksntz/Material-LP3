namespace Classes;

public class Judo : Gastos
{
    private readonly decimal bonus = -50m;

    public Judo (string cliente, decimal valorInicial, decimal bonusJudo = -50) : base(cliente, valorInicial)
    => bonus = bonusJudo;

    public override void MargemDeSeguranca()
{
    decimal margem = ValorAcumulado * 0.02m;
    EfetuarTransacao(margem, DateTime.Now, "Margem de segurança para Judô");
    if (bonus != 0)
    {
        EfetuarTransacao(bonus, DateTime.Now, "Bonus para Judô");
    }
}
}