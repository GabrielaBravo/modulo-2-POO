using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();
        produto.nome = "Leite Integral";
        produto.valor = 5;
        produto.setData(new DateTime(2023, 3, 1));
        Venda venda = new Venda();
        venda.produto = produto;
        venda.setData(DateTime.Now);
        TestarVenda.DetalhesVenda(venda);

    }
}

public interface IData
{
    void setData(DateTime data);
    DateTime getData();
    string dataString { get; }
}

public class Produto : IData
{
    public string nome { get; set; }
    public decimal valor { get; set; }
    private DateTime data { get; set; }

    public void setData(DateTime data)
    {
        this.data = data;
    }

    public DateTime getData()
    {
        return data;
    }

    public string dataString => data.ToString("dd/MM/yyyy");

    public Produto()
    {
        nome = nome;
        valor = valor;
        data = data;
    }
}

public class Venda : IData
{
    public Produto produto { get; set; }
    private DateTime data { get; set; }

    public void setData(DateTime data)
    {
        this.data = data;
    }

    public DateTime getData()
    {
        return data;
    }

    public string dataString => data.ToString("dd/MM/yyyy");
}

public static class TestarVenda
{
    public static string DetalhesVenda(Venda venda)
    {
        return $"Data da venda: {venda.getData().ToString("dd/MM/yyyy")} - Produto: {venda.produto.nome} - Valor do produto: {venda.produto.valor} - Vencimento: {venda.produto.dataString}";
    }
}