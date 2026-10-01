using System;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao()
    {
        DefinirNome("Atividade de Respiração");

        DefinirDescricao(
            "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. " +
            "Limpe sua mente e concentre-se na sua respiração."
        );
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime tempoFinal =
            DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < tempoFinal)
        {
            Console.Write("Inspire...");
            ExibirContagemRegressiva(4);
            Console.WriteLine();

            if (DateTime.Now >= tempoFinal)
            {
                break;
            }

            Console.Write("Expire...");
            ExibirContagemRegressiva(4);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}