public class GeradorDePerguntas
{
    public List<string> _perguntas;
    public GeradorDePerguntas()
    {
        _perguntas = new List<string>();

        _perguntas.Add("Quem foi a pessoa mais interessante com quem interagi hoje?");
        _perguntas.Add("Qual foi a melhor parte do meu dia?");
        _perguntas.Add("Como vi a mão do Senhor em minha vida hoje?");
        _perguntas.Add("Qual foi a emoção mais forte que senti hoje?");
        _perguntas.Add("Se eu pudesse fazer uma coisa hoje, o que seria?");
        _perguntas.Add("Ocorreu algo de diferente do meu dia a dia? Teve algum imprevisto?");
        _perguntas.Add("Fiz algo específico com os meus familiares ou amigos?");
    }

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();

        int indice = random.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}