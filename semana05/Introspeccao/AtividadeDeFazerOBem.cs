using System;
using System.Collections.Generic;

public class AtividadeDeFazerOBem : Atividade
{
    private List<string> _pessoas;
    private List<string> _perguntas;

    public AtividadeDeFazerOBem()
    {
        DefinirNome("Planejar Fazer o Bem");

        DefinirDescricao(
            "Esta atividade ajudará você a pensar em alguém que você pode ajudar " +
            "e a criar um plano simples para fazer algo de bom por essa pessoa."
        );

        _pessoas = new List<string>
        {
            "um familiar",
            "um amigo",
            "um colega de trabalho ou estudo",
            "um vizinho",
            "alguém que esteja passando por uma dificuldade",
            "uma pessoa que você não conhece muito bem"
        };

        _perguntas = new List<string>
        {
            "O que essa pessoa pode estar precisando neste momento?",
            "Que tipo de ajuda você poderia oferecer?",
            "Por que você escolheu ajudar essa pessoa?",
            "Quando você poderia realizar essa ação?",
            "Existe alguma coisa que pode impedir você de realizar esse plano?",
            "O que você precisa fazer primeiro?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine("Vamos pensar em uma oportunidade para fazer o bem.");
        Console.WriteLine();

        Console.WriteLine(
            $"Você pode pensar em ajudar {ObterPessoaAleatoria()}."
        );

        Console.WriteLine();

        Console.WriteLine("Reserve alguns segundos para pensar nessa pessoa.");

        ExibirProgresso(5);

        Console.WriteLine();
        Console.WriteLine();

        DateTime tempoFinal =
            DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < tempoFinal)
        {
            Console.WriteLine(ObterPerguntaAleatoria());

            ExibirProgresso(5);

            Console.WriteLine();

            if (DateTime.Now >= tempoFinal)
            {
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Agora pense em uma ação específica que você pode realizar.");

        ExibirContagemRegressiva(5);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(
            "Guarde seu plano em mente e procure realizá-lo."
        );

        ExibirMensagemFinal();
    }

    private string ObterPessoaAleatoria()
    {
        Random random = new Random();

        int indice = random.Next(_pessoas.Count);

        return _pessoas[indice];
    }

    private string ObterPerguntaAleatoria()
    {
        Random random = new Random();

        int indice = random.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}