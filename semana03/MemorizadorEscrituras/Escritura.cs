namespace MemorizadorEscrituras;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void EsconderPalavrasAleatorias(int numeroParaEsconder)
    {
        Random random = new Random();

        for (int i = 0; i < numeroParaEsconder; i++)
        {
            int indice = random.Next(_palavras.Count);

            _palavras[indice].Esconder();
        }
    }

    public string ObterTexto()
    {
        string texto = _referencia.ObterTexto() + " ";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTexto() + " ";
        }

        return texto.Trim();
    }

    public bool EstaCompletamenteEscondida()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaEscondida())
            {
                return false;
            }
        }

        return true;
    }
}