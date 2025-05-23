using System;

internal class Produtos
{
    private string descricao;
    private double valor;
    private int quantidade;

    public Produtos()
    {
        descricao = "";
        valor = 0;
        quantidade = 0;
    }

    public Produtos(string descricao, double valor, int quantidade)
    {
        this.descricao = descricao;
        this.valor = valor;
        this.quantidade = quantidade;
    }

    public string Descricao
    {
        get { return descricao; }
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

    public override string ToString()
    {
        return $"{descricao} - R$ {valor:F2}";
    }

}
