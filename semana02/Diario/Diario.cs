using System;
using System.Collections.Generic;
using System.IO;
public class Diario
{
    public List<Registro> _registros;
    public Diario()
    {
        _registros = new List<Registro>();
    }
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }
    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvaNoArquivo(string arquivo)
    {
        using (StreamWriter escritor = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                escritor.WriteLine(registro.ParaArquivo());
            }
        }

        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void CarregarDoArquivo(string arquivo)
    {
        _registros.Clear();
        string[] linhas = File.ReadAllLines(arquivo);
        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');
            if (partes.Length >= 3)
            {
                Registro registro = new Registro();

                registro._data = partes[0];
                registro._textoPergunta = partes[1];
                registro._textoResposta = partes[2];

                _registros.Add(registro);
            }
        }

        Console.WriteLine("Diário carregado com sucesso!");
    }
}