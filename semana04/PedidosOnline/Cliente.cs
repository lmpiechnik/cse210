class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    public string GetNome()
    {
        return _nome;
    }

    public bool MoraNosEUA()
    {
        return _endereco.EhNosEUA();
    }

    public Endereco GetEndereco()
    {
        return _endereco;
    }
}