using System;

// CRIATIVIDADE:
// Além das três atividades exigidas pelo projeto, foi adicionada uma quarta
// atividade chamada "Planejar Fazer o Bem". Ela orienta o usuário a pensar
// em alguém que pode ajudar, refletir sobre como ajudar e criar um plano
// para realizar uma ação positiva.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Menu de Atividades de Introspecção");
            Console.WriteLine();
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Planejar Fazer o Bem");
            Console.WriteLine("5. Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                AtividadeDeRespiracao atividade =
                    new AtividadeDeRespiracao();

                atividade.Executar();
            }
            else if (opcao == "2")
            {
                AtividadeDeReflexao atividade =
                    new AtividadeDeReflexao();

                atividade.Executar();
            }
            else if (opcao == "3")
            {
                AtividadeDeListagem atividade =
                    new AtividadeDeListagem();

                atividade.Executar();
            }
            else if (opcao == "4")
            {
                AtividadeDeFazerOBem atividade =
                    new AtividadeDeFazerOBem();

                atividade.Executar();
            }
            else if (opcao == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Até a próxima!");
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}