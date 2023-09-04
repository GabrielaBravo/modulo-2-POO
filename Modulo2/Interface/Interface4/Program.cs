using System;

public class Solution
{

}

public interface IVeiculo
{
    string Dirigir();
    bool Reabastecer(int quantidadeGasolina);
}

public class Carro : IVeiculo
{
    public int quantidadeGasolina { get; set; }

    public Carro(int quantidadeGasolinaInicial)
    {
        quantidadeGasolina = quantidadeGasolinaInicial;
    }

    public string Dirigir()
    {
        if (quantidadeGasolina > 0)
        {
            return "Dirigindo";
        }
        else
        {
            return "Sem combustível";
        }
    }

    public bool Reabastecer(int quantidadeGasolina)
    {
        if (quantidadeGasolina > 0)
        {
            this.quantidadeGasolina += quantidadeGasolina;
            return true;
        }
        else
        {
            return false;
        }
    }
}