
using System.Linq;
using System.Reflection;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string result1 = Reflection.ConcatStringMembers(null); // Retorna ""
        Console.WriteLine(result1);

        testClass obj = new testClass();
        string result2 = Reflection.ConcatStringMembers(obj); // Retorna "OutputIt"
        Console.WriteLine(result2);


    }


    public class testClass
    {
        public string Output1()
        {
            return "Output";
        }

        public string Output2()
        {
            return "It";
        }
    }

    public static class Reflection
    {
        public static string ConcatStringMembers(object TestObject)
        {
            if (TestObject == null)
                return "";

            Type objectType = TestObject.GetType();
            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            string result = "";

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(string) && property.GetMethod != null)
                {
                    result += (string)property.GetValue(TestObject);
                }
            }

            return result;
        }
    }
    }



