namespace MemorizadorEscrituras;

class Program
{
    static void Main(string[] args)
    {
        // Funcionalidade extra: o programa possui uma pequena biblioteca
        // de escrituras para o usuário escolher antes de iniciar a memorização.

        List<Escritura> biblioteca = new List<Escritura>();

        biblioteca.Add(new Escritura(
            new Referencia("João", 3, 16),
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna."
        ));

        biblioteca.Add(new Escritura(
            new Referencia("Provérbios", 3, 5, 6),
            "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos e ele endireitará as tuas veredas."
        ));

        biblioteca.Add(new Escritura(
            new Referencia("Salmos", 23, 1),
            "O Senhor é o meu pastor e nada me faltará."
        ));

        biblioteca.Add(new Escritura(
            new Referencia("Filipenses", 4, 13),
            "Posso todas as coisas naquele que me fortalece."
        ));

        Console.Clear();

        Console.WriteLine("=== MEMORIZADOR DE ESCRITURAS ===");
        Console.WriteLine();
        Console.WriteLine("Escolha uma escritura:");
        Console.WriteLine();

        for (int i = 0; i < biblioteca.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {biblioteca[i].ObterTexto()}");
        }

        Console.WriteLine();
        Console.Write("Digite o número da escritura: ");

        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int escolha) ||
            escolha < 1 ||
            escolha > biblioteca.Count)
        {
            Console.WriteLine("Escolha inválida.");
            return;
        }

        Escritura escritura = biblioteca[escolha - 1];

        while (!escritura.EstaCompletamenteEscondida())
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();
            Console.Write("Pressione Enter para continuar ou digite 'sair': ");

            entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            escritura.EsconderPalavrasAleatorias(3);
        }

        Console.Clear();
        Console.WriteLine(escritura.ObterTexto());
    }
}