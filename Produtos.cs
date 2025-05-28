using System;
using Cantinaa;

internal class Produtos
{
    private string descricao;
    private double valor;
    private int quantidade;
    private bool isChapa;

    public Produtos()
    {
        descricao = "";
        valor = 0;
        quantidade = 0;
        isChapa = false;
    }

    public Produtos(string descricao, double valor, int quantidade, bool isChapa)
    {
        this.descricao = descricao;
        this.valor = valor;
        this.quantidade = quantidade;
        this.isChapa = isChapa;
    }


    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }

    public double Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public int Quantidade
    {
        get { return quantidade; }
        set { quantidade = value; }
    }
    public bool IsChapa 
    { 
        get { return isChapa;}
        set { isChapa = value;}
    }

    public override string ToString()
    {
        return $"{descricao} - R$ {valor:F2}";
    }

}
