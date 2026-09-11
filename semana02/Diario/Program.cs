using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        string opcao = "";

        while (opcao != "5")
        {

            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao programa Diário!");
            Console.WriteLine("Por favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");

            opcao = Console.ReadLine();

            if (opcao == "1")
            {

                string pergunta = gerador.ObterPerguntaAleatoria();

                Console.WriteLine();
                Console.WriteLine(pergunta);
                Console.Write("Resposta: ");

                string resposta = Console.ReadLine();

                Registro registro = new Registro();

                registro._data = DateTime.Now.ToShortDateString();
                registro._textoPergunta = pergunta;
                registro._textoResposta = resposta;

                diario.AdicionarRegistro(registro);

                Console.WriteLine("Registro adicionado ao diário!");
            }

            else if (opcao == "2")
            {
                Console.WriteLine();

                diario.ExibirTodos();
            }
            else if (opcao == "3")
            {
                Console.Write("Digite o nome do arquivo: ");
                string arquivo = Console.ReadLine();

                diario.CarregarDoArquivo(arquivo);
            }
            else if (opcao == "4")
            {
                Console.Write("Digite o nome do arquivo: ");
                string arquivo = Console.ReadLine();



                diario.SalvaNoArquivo(arquivo);
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}









