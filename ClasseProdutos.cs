using System;

internal class ClasseProdutos
{
    private string descricao;
    private double valor;
    private int quantidade;

    public ClasseProdutos()
    {
        descricao = "";
        valor = 0;
        quantidade = 0;

    }

    public ClasseProdutos(string descricao, double valor)
    {
        this.descricao = descricao;
        this.valor = valor;
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
