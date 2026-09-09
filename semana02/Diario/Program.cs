using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        Registro registro = new Registro();
        registro.Exibir();

        Console.WriteLine("Olá, Mundo! Este é o Projeto Diario.");
    }
}