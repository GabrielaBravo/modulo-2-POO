using static Program;
using static Program.Triangulo;

internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        retangulo.Cor = "Azul";
        retangulo.Lado1 = 3.5;
        retangulo.Lado2 = 2;
        Console.WriteLine(Teste.DetalhesFigura(retangulo));
    }

    public abstract class Figura
    {
        public abstract string Cor { get; set; }
        public abstract double Area();
    }

    public class Retangulo : Figura
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public override string Cor { get; set; }

        public override double Area()
        {
            return Lado1 * Lado2;
        }

    }

    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override string Cor { get; set; }

        public override double Area()
        {
            return Base * Altura;
        }

        public static class Teste 
        {
            public static string DetalhesFigura(Figura figura)
            {
                return $"Cor da figura: {figura.Cor} - Área da figura: {figura.Area()}";
            }
        }
    }
}

