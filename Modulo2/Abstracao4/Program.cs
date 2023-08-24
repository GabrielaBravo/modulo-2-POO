using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        DiaDosNamorados diaDosNamorados = new DiaDosNamorados("José");
        Natal natal = new Natal("Maria");
        Aniversario aniversario = new Aniversario("João");

        TesteCartao(diaDosNamorados);
        TesteCartao(natal);
        TesteCartao(aniversario);

    }

    public abstract class CartaoWeb
    {
        public abstract string Destinatario { get; set; }
        public abstract void ShowMessage();
    }

    public class DiaDosNamorados : CartaoWeb
    {
        public override string Destinatario { get; set; }

        public DiaDosNamorados(string destinatario)
        {
            Destinatario = destinatario;
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz Dia dos Namorados, {Destinatario}!");
        }

    }

    public class Natal : CartaoWeb
    {
        public override string Destinatario { get; set; }

        public Natal(string destinatario)
        {
            Destinatario = destinatario;
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz Natal, {Destinatario}!");
        }

    }

    public class Aniversario : CartaoWeb
    {
        public override string Destinatario { get; set; }

        public Aniversario(string destinatario)
        {
            Destinatario = destinatario;
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz Aniversário, {Destinatario}!");
        }

    }
    public static void TesteCartao(CartaoWeb cartao)
    {
        cartao.ShowMessage();
    }
}