public class Registro
{
    public string _data;
    public string _textoPergunta;
    public string _textoResposta;

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_textoPergunta}");
        Console.WriteLine($"Resposta: {_textoResposta}");
        Console.WriteLine();
    }

    public string ParaArquivo()
    {
        return $"{_data}|{_textoPergunta}|{_textoResposta}";
    }
}