
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Atividade> atividades = new List<Atividade>();

        atividades.Add(new Corrida(
            new DateTime(2022, 11, 3), 30, 4.8));

        atividades.Add(new Ciclismo(
            new DateTime(2022, 11, 3), 30, 20.0));

        atividades.Add(new Natacao(
            new DateTime(2022, 11, 3), 30, 40));

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}
