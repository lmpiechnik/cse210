using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================
        // PEDIDO 1
        // ==========================

        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Cliente cliente1 = new Cliente(
            "John Smith",
            endereco1
        );

        Pedido pedido1 = new Pedido(cliente1);

        Produto produto1 = new Produto(
            "Teclado Mecânico",
            "P001",
            75.00,
            1
        );

        Produto produto2 = new Produto(
            "Mouse Gamer",
            "P002",
            40.00,
            2
        );

        Produto produto3 = new Produto(
            "Headset",
            "P003",
            60.00,
            1
        );

        pedido1.AdicionarProduto(produto1);
        pedido1.AdicionarProduto(produto2);
        pedido1.AdicionarProduto(produto3);


        // ==========================
        // PEDIDO 2
        // ==========================

        Endereco endereco2 = new Endereco(
            "Rua das Flores, 250",
            "Curitiba",
            "Paraná",
            "Brasil"
        );

        Cliente cliente2 = new Cliente(
            "Carlos Silva",
            endereco2
        );

        Pedido pedido2 = new Pedido(cliente2);

        Produto produto4 = new Produto(
            "Monitor",
            "P004",
            250.00,
            1
        );

        Produto produto5 = new Produto(
            "Webcam",
            "P005",
            80.00,
            1
        );

        Produto produto6 = new Produto(
            "Microfone",
            "P006",
            120.00,
            2
        );

        pedido2.AdicionarProduto(produto4);
        pedido2.AdicionarProduto(produto5);
        pedido2.AdicionarProduto(produto6);


        // ==========================
        // EXIBIR PEDIDO 1
        // ==========================

        Console.WriteLine("========================================");
        Console.WriteLine("PEDIDO 1");
        Console.WriteLine("========================================");

        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine(pedido1.ObterEtiquetaEnvio());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Preço total: ${pedido1.CalcularTotal():F2}");

        Console.WriteLine();


        // ==========================
        // EXIBIR PEDIDO 2
        // ==========================

        Console.WriteLine("========================================");
        Console.WriteLine("PEDIDO 2");
        Console.WriteLine("========================================");

        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine(pedido2.ObterEtiquetaEnvio());

        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Preço total: ${pedido2.CalcularTotal():F2}");
    }
}