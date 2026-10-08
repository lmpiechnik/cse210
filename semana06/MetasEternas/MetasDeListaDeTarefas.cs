public class MetaDeListaDeTarefas : Meta
{
    private int _concluidas;
    private int _total;
    private int _bonus;

    public MetaDeListaDeTarefas(
        string nome,
        string descricao,
        int pontos,
        int total,
        int bonus)
        : base(nome, descricao, pontos)
    {
        _concluidas = 0;
        _total = total;
        _bonus = bonus;
    }

    public override int RegistrarEvento()
    {
        if (_concluidas >= _total)
        {
            return 0;
        }

        _concluidas++;

        int pontosGanhos = ObterPontos();

        if (_concluidas == _total)
        {
            pontosGanhos += _bonus;
        }

        return pontosGanhos;
    }

    public override bool EstaConcluida()
    {
        return _concluidas >= _total;
    }

    public override string ObterDetalhesEmTexto()
    {
        string caixa = EstaConcluida() ? "[X]" : "[ ]";

        return $"{caixa} {ObterNome()} ({ObterDescricao()}) " +
               $"-- Concluída {_concluidas}/{_total} vezes";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"Lista|{ObterNome()}|{ObterDescricao()}|" +
               $"{ObterPontos()}|{_concluidas}|{_total}|{_bonus}";
    }
}