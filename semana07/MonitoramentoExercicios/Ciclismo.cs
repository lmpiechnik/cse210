
public class Ciclismo : Atividade
{
    private double _velocidade;

    public Ciclismo(DateTime data, int duracao, double velocidade)
        : base(data, duracao)
    {
        _velocidade = velocidade;
    }

    public override double ObterDistancia()
    {
        return (_velocidade * ObterDuracao()) / 60;
    }

    public override double ObterVelocidade()
    {
        return _velocidade;
    }

    public override double ObterRitmo()
    {
        return 60 / _velocidade;
    }

    public override string ObterResumo()
    {
        return $"{ObterData():dd MMM yyyy} Ciclismo " +
               $"({ObterDuracao()} min) - " +
               $"Distância {ObterDistancia():0.0} km, " +
               $"Velocidade: {ObterVelocidade():0.0} km/h, " +
               $"Ritmo: {ObterRitmo():0.00} min por km";
    }
}
