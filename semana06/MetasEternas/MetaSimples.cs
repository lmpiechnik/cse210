public class MetaSimples : Meta
{
    private bool _estaConcluida;

    public MetaSimples(string nome, string descricao, int pontos)
        : base(nome, descricao, pontos)
    {
        _estaConcluida = false;
    }

    public override int RegistrarEvento()
    {
        if (!_estaConcluida)
        {
            _estaConcluida = true;
            return ObterPontos();
        }

        return 0;
    }

    public override bool EstaConcluida()
    {
        return _estaConcluida;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"Simples|{ObterNome()}|{ObterDescricao()}|{ObterPontos()}|{_estaConcluida}";
    }

    public void DefinirConcluida(bool concluida)
    {
        _estaConcluida = concluida;
    }
}