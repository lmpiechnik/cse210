using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;

    public AtividadeDeListagem()
    {
        DefinirNome("Atividade de Listagem");

        DefinirDescricao(
            "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, " +
            "fazendo com que você liste o máximo de coisas que puder em uma determinada área."
        );

        _contador = 0;

        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine("Pense sobre a seguinte questão:");
        Console.WriteLine();

        Console.WriteLine(ObterPerguntaAleatoria());

        Console.WriteLine();
        Console.WriteLine("Comece em:");

        ExibirContagemRegressiva(5);

        Console.WriteLine();
        Console.WriteLine();

        List<string> respostas = ObterListaDoUsuario();

        Console.WriteLine();
        Console.WriteLine($"Você listou {_contador} itens.");

        ExibirMensagemFinal();
    }

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();

        int indice = random.Next(_perguntas.Count);

        return _perguntas[indice];
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> respostas = new List<string>();

        DateTime tempoFinal =
            DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < tempoFinal)
        {
            Console.Write("> ");

            string resposta = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(resposta))
            {
                respostas.Add(resposta);
                _contador++;
            }
        }

        return respostas;
    }
}