using System;
using System.Collections.Generic;

class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "ETIQUETA DE EMBALAGEM\n";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"Produto: {produto.GetNome()} | ID: {produto.GetIdProduto()}\n";
        }

        return etiqueta;
    }

    public string ObterEtiquetaEnvio()
    {
        return $"ETIQUETA DE ENVIO\n" +
               $"Nome: {_cliente.GetNome()}\n" +
               $"{_cliente.GetEndereco().ObterEnderecoCompleto()}";
    }
}