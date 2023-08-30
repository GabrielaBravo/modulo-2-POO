using Reflection;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        /*int inteiro = 10;
            string texto = "Ada";

            Type tipo = inteiro.GetType();

            Console.WriteLine(tipo.Name);
            Console.WriteLine(texto.GetType().Name);*/

        Bicicleta bike = new Bicicleta("Caloi", 15, 16, 18, "Moutain Bike");
        bike.ImprimeDados();

        Console.WriteLine(bike.GetType().Name);

        //Mostrar todas as propriedades publicas
        PropertyInfo[] propriedades = bike.GetType().GetProperties();
        Console.WriteLine($"O tipo {bike.GetType().Name} possui {propriedades.Length} propriedades");
        foreach (var propriedade in propriedades)
        {
            Console.WriteLine($"Tenho a propriedade {propriedade.Name} que é do tipo {propriedade.PropertyType.Name} e meu valor é {propriedade.GetValue(bike)}.");
        }

        PropertyInfo propTipoQuadro = bike.GetType().GetProperty("TipoQuadro");

        //TipoQuadro
        propTipoQuadro.SetValue(bike, "Velocity");

        Console.WriteLine(propTipoQuadro.GetValue(bike));

        Console.WriteLine(bike.TipoQuadro);

        var propModelo = propriedades.FirstOrDefault(x => x.Name == "Modelo");
        propModelo.SetValue(bike, "Caloi2");

        bike.ImprimeDados();
        ImprimeReflection(bike);

        Notebook note = new("Intel", "16Gb", "Intel I7", 14.7);
        note.ImprimeDados();
        ImprimeReflection(note);

    }
    public static void ImprimeReflection(Object objeto)
    {
        Console.WriteLine("----------------------------------");
        Type tipo = objeto.GetType();
        Console.WriteLine($"Tipo do objeto: {tipo.Name}");

        PropertyInfo[] propriedades = tipo.GetProperties();
        foreach (PropertyInfo propriedade in propriedades)
        {
            object valor = propriedade.GetValue(objeto);
            Console.WriteLine($"Propriedade: {propriedade.Name} , Tipo: {propriedade.PropertyType.FullName} , Valor: {valor}");
        }
    }

}