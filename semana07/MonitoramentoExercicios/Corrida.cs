
public class Corrida : Atividade
{
    private double _distancia;

    public Corrida(DateTime data, int duracao, double distancia)
        : base(data, duracao)
    {
        _distancia = distancia;
    }

    public override double ObterDistancia()
    {
        return _distancia;
    }

    public override double ObterVelocidade()
    {
        return (ObterDistancia() / ObterDuracao()) * 60;
    }

    public override double ObterRitmo()
    {
        return ObterDuracao() / ObterDistancia();
    }

    public override string ObterResumo()
    {
        return $"{ObterData():dd MMM yyyy} Corrida " +
               $"({ObterDuracao()} min) - " +
               $"Distância {ObterDistancia():0.0} km, " +
               $"Velocidade: {ObterVelocidade():0.0} km/h, " +
               $"Ritmo: {ObterRitmo():0.00} min por km";
    }
}
