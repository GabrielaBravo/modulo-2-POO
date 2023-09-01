internal class Program
{
    private static void Main(string[] args)
    {
        int intValue = 15;
        string stringValue = "Teste";

        string resultInt = ServicoImpressao.ImprimeValorETipo(intValue);
        string resultString = ServicoImpressao.ImprimeValorETipo(stringValue);

        Console.WriteLine(resultInt);    
        Console.WriteLine(resultString); 
    }
    public static class ServicoImpressao
    {
        public static string ImprimeValorETipo<T>(T valor) 
        {   
            Type tipo1 = typeof(T);

            string tipo = tipo1.Name;

            if (tipo == "Int32")
            {
                tipo = "Int";
            }

            return $"{tipo}: {valor}";
        }
    }
}
