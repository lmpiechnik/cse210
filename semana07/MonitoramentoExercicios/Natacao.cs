
public class Natacao : Atividade
{
    private int _voltas;

    public Natacao(DateTime data, int duracao, int voltas)
        : base(data, duracao)
    {
        _voltas = voltas;
    }

    public override double ObterDistancia()
    {
        return (_voltas * 50.0) / 1000;
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
        return $"{ObterData():dd MMM yyyy} Natação " +
               $"({ObterDuracao()} min) - " +
               $"Distância {ObterDistancia():0.0} km, " +
               $"Velocidade: {ObterVelocidade():0.0} km/h, " +
               $"Ritmo: {ObterRitmo():0.00} min por km";
    }
}
