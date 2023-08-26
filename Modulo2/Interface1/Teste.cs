using Interface1;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        //                CCrie uma interface Exercicio contendo os contratos para:
        //                FazerProva - implementado
        //                FazerTreino - implementado
        //                FazerFortalecimento - contrato
        //                FazerAlongamento - contrato

        //                Crie uma classe Natacao que implemente os métodos
        //                Fortalecimento -> Malhar membros superiores e inferiores
        //                Alongamento -> Alongar membros superiores e inferiores
        //                Crie uma classe CorridaObstaculos que implemente os métodos
        //                Fortalecimento -> Malhar membros inferiores
        //                Alongamento -> Alongar membros inferiores

        //                Crie uma classe teste

        Natacao natacao = new Natacao();
        CorridaObstaculos corrida = new CorridaObstaculos();

        Console.WriteLine("=== Natação ===");
        natacao.FazerProva();
        natacao.FazerTreino();
        natacao.FazerFortalecimento();
        natacao.FazerAlongamento();

        Console.WriteLine("\n=== Corrida de Obstáculos ===");
        corrida.FazerProva();
        corrida.FazerTreino();
        corrida.FazerFortalecimento();
        corrida.FazerAlongamento();

    }
}