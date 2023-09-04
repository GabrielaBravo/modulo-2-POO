using GerenciamentoEmpresaInterface;

internal class Program
{
    private static void Main(string[] args)
    {
        EnviarNotificacaoWhatsApp notificacaoWhatsApp = new();
        List<IEmpresa> empresas = new List<IEmpresa>
        {
            new Varejo("BTG", "Rua das Flores", 0000001, notificacaoWhatsApp),
            new Empreiteira("Ada", "Rua das Amoras", 000002)
        };

      

        foreach (var empresa in empresas)
        {
            empresa.ImprimirInformacoes();
            empresa.RealizarVenda();
            Console.WriteLine();
        }

        Console.ReadKey();

    }
}