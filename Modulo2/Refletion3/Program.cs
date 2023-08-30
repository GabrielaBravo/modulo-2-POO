internal class Program
{
    private static void Main(string[] args)
    {
        Object obj = new Object();
        bool result = Utils.isClass(obj); // Verifica se obj é uma classe

        if (result)
        {
            Console.WriteLine("O objeto é uma classe.");
        }
        else
        {
            Console.WriteLine("O objeto não é uma classe.");
        }
    }

    public static class Utils
    {
        public static bool isClass(object obj)
        {


            if (obj == null)
                return false;

            Type objectType = obj.GetType();

            return objectType.IsClass;

        }
    }
}