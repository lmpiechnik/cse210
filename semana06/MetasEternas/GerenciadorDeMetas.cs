using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos;

    public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    public void Iniciar()
    {
        bool continuar = true;

        while (continuar)
        {
            ExibirInfoJogador();

            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("  1. Criar nova meta");
            Console.WriteLine("  2. Listar metas");
            Console.WriteLine("  3. Registrar evento");
            Console.WriteLine("  4. Salvar metas");
            Console.WriteLine("  5. Carregar metas");
            Console.WriteLine("  6. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    CriarMeta();
                    break;

                case "2":
                    ListarDetalhesDasMetas();
                    break;

                case "3":
                    RegistrarEvento();
                    break;

                case "4":
                    SalvarMetas();
                    break;

                case "5":
                    CarregarMetas();
                    break;

                case "6":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"Pontuação: {_pontos}");
        Console.WriteLine($"Nível: {ObterNivel()}");
    }

    public void ListarNomesDasMetas()
    {
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
        }
    }

    public void ListarDetalhesDasMetas()
    {
        if (_metas.Count == 0)
        {
            Console.WriteLine("Nenhuma meta cadastrada.");
            return;
        }

        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void CriarMeta()
    {
        Console.WriteLine("Tipos de meta:");
        Console.WriteLine("1. Meta simples");
        Console.WriteLine("2. Meta eterna");
        Console.WriteLine("3. Meta de lista de tarefas");

        Console.Write("Escolha o tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Nome da meta: ");
        string nome = Console.ReadLine();

        Console.Write("Descrição: ");
        string descricao = Console.ReadLine();

        Console.Write("Quantidade de pontos: ");
        int pontos = int.Parse(Console.ReadLine());

        Meta novaMeta = null;

        if (tipo == "1")
        {
            novaMeta = new MetaSimples(nome, descricao, pontos);
        }
        else if (tipo == "2")
        {
            novaMeta = new MetaEterna(nome, descricao, pontos);
        }
        else if (tipo == "3")
        {
            Console.Write("Quantas vezes precisa ser realizada? ");
            int total = int.Parse(Console.ReadLine());

            Console.Write("Quantidade do bônus: ");
            int bonus = int.Parse(Console.ReadLine());

            novaMeta = new MetaDeListaDeTarefas(
                nome,
                descricao,
                pontos,
                total,
                bonus);
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
            return;
        }

        _metas.Add(novaMeta);

        Console.WriteLine("Meta criada com sucesso!");
    }

    public void RegistrarEvento()
    {
        if (_metas.Count == 0)
        {
            Console.WriteLine("Você ainda não possui metas.");
            return;
        }

        Console.WriteLine("Escolha uma meta para registrar:");

        ListarNomesDasMetas();

        Console.Write("Número da meta: ");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha < 1 || escolha > _metas.Count)
        {
            Console.WriteLine("Meta inválida.");
            return;
        }

        Meta meta = _metas[escolha - 1];

        int pontosGanhos = meta.RegistrarEvento();

        _pontos += pontosGanhos;

        Console.WriteLine();
        Console.WriteLine($"Você ganhou {pontosGanhos} pontos!");

        if (meta.EstaConcluida())
        {
            Console.WriteLine("Parabéns! Meta concluída!");
        }

        Console.WriteLine($"Pontuação atual: {_pontos}");
        Console.WriteLine($"Nível atual: {ObterNivel()}");
    }

    public void SalvarMetas()
    {
        Console.Write("Digite o nome do arquivo: ");
        string nomeArquivo = Console.ReadLine();

        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            arquivo.WriteLine(_pontos);

            foreach (Meta meta in _metas)
            {
                arquivo.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }

        Console.WriteLine("Metas salvas com sucesso!");
    }

    public void CarregarMetas()
    {
        Console.Write("Digite o nome do arquivo: ");
        string nomeArquivo = Console.ReadLine();

        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string[] linhas = File.ReadAllLines(nomeArquivo);

        if (linhas.Length == 0)
        {
            Console.WriteLine("Arquivo vazio.");
            return;
        }

        _metas.Clear();

        _pontos = int.Parse(linhas[0]);

        for (int i = 1; i < linhas.Length; i++)
        {
            string[] partes = linhas[i].Split('|');

            string tipo = partes[0];
            string nome = partes[1];
            string descricao = partes[2];
            int pontos = int.Parse(partes[3]);

            if (tipo == "Simples")
            {
                MetaSimples meta = new MetaSimples(
                    nome,
                    descricao,
                    pontos);

                _metas.Add(meta);
            }
            else if (tipo == "Eterna")
            {
                MetaEterna meta = new MetaEterna(
                    nome,
                    descricao,
                    pontos);

                _metas.Add(meta);
            }
            else if (tipo == "Lista")
            {
                int concluidas = int.Parse(partes[4]);
                int total = int.Parse(partes[5]);
                int bonus = int.Parse(partes[6]);

                MetaDeListaDeTarefas meta =
                    new MetaDeListaDeTarefas(
                        nome,
                        descricao,
                        pontos,
                        total,
                        bonus);

                // Precisamos restaurar a quantidade já concluída.
                for (int j = 0; j < concluidas; j++)
                {
                    meta.RegistrarEvento();
                }

                _metas.Add(meta);
            }
        }

        Console.WriteLine("Metas carregadas com sucesso!");
    }

    private int ObterNivel()
    {
        return (_pontos / 1000) + 1;
    }
}