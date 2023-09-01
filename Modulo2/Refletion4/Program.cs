using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        AlgumaClasse obj = new AlgumaClasse();
        List<string> propertyNames = Reflections.RetornaPropriedadesPublicas(obj);

        Console.WriteLine("Propriedades públicas da classe:");
        foreach (string propertyName in propertyNames)
        {
            Console.WriteLine(propertyName);
        }
    }

    public class AlgumaClasse
    {

        public int CampoX;

        private int CampoY;
        public int Propriedade1 { get; set; }
        private int Propriedade2 { get; set; }

        public string Metodo1()
        {
            return "Método1 chamado";
        }

        private string Metodo2()
        {
            return "Method2 chamado";
        }
    }

    public static class Reflections
    {
        public static List<string> RetornaPropriedadesPublicas(object obj)
        {
            List<string> publicPropertyNames = new List<string>();

            if (obj == null)
                return publicPropertyNames;

            Type objectType = obj.GetType();
            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                publicPropertyNames.Add(property.Name);
            }

            return publicPropertyNames;
        }
    }
}