using System;
using System.Threading;

public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade()
    {
        _nome = "";
        _descricao = "";
        _duracao = 0;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();

        Console.WriteLine($"--- {_nome} ---");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();

        Console.Write("Por quanto tempo, em segundos, você gostaria de realizar esta atividade? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare-se...");

        ExibirContagemRegressiva(3);

        Console.WriteLine();
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!");
        Console.WriteLine();

        Console.WriteLine(
            $"Você completou a atividade de {_nome} por {_duracao} segundos."
        );

        Console.WriteLine();

        ExibirProgresso(3);

        Console.WriteLine();
    }

    public void ExibirProgresso(int segundos)
    {
        string[] simbolos = { "|", "/", "-", "\\" };

        DateTime tempoFinal = DateTime.Now.AddSeconds(segundos);

        int indice = 0;

        while (DateTime.Now < tempoFinal)
        {
            Console.Write(simbolos[indice]);

            Thread.Sleep(250);

            Console.Write("\b \b");

            indice++;

            if (indice >= simbolos.Length)
            {
                indice = 0;
            }
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }

    protected void DefinirNome(string nome)
    {
        _nome = nome;
    }

    protected void DefinirDescricao(string descricao)
    {
        _descricao = descricao;
    }

    protected int ObterDuracao()
    {
        return _duracao;
    }
}