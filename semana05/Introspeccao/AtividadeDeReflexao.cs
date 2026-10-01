using System;
using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao()
    {
        DefinirNome("Atividade de Reflexão");

        DefinirDescricao(
            "Esta atividade ajudará você a refletir sobre momentos da sua vida em que " +
            "você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder " +
            "que você tem e como pode usá-lo em outros aspectos da sua vida."
        );

        _reflexoes = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?",
            "Como você pode manter essa experiência em mente no futuro?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine("Considere a seguinte situação:");
        Console.WriteLine();

        ExibirReflexoes();

        Console.WriteLine();
        Console.WriteLine("Comece a refletir...");

        ExibirProgresso(3);

        Console.WriteLine();

        DateTime tempoFinal =
            DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < tempoFinal)
        {
            ExibirPerguntas();

            ExibirProgresso(5);

            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }

    public string ObterReflexoesAleatorias()
    {
        Random random = new Random();

        int indice = random.Next(_reflexoes.Count);

        return _reflexoes[indice];
    }

    public string ObterPerguntasAleatorias()
    {
        Random random = new Random();

        int indice = random.Next(_perguntas.Count);

        return _perguntas[indice];
    }

    public void ExibirReflexoes()
    {
        Console.WriteLine(ObterReflexoesAleatorias());
    }

    public void ExibirPerguntas()
    {
        Console.WriteLine();
        Console.WriteLine(ObterPerguntasAleatorias());
    }
}