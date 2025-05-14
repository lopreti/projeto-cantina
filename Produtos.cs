using System;

internal class Produtos
{
    private string descricao;
    private double valor;

    public Produtos()
    {
        descricao = "";
        valor = 0;

    }

    public Produtos(string descricao, double valor)
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

    public override string ToString()
    {
        return $"{descricao} - R$ {valor}";
    }
      

}
