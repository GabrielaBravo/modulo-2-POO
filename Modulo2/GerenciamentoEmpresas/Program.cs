using GerenciamentoEmpresas;

internal class Program
{
    public static void Main(string[] args)
    {
        Varejo empresa = new("BTG", "Rua das Flores", 0000001);
        empresa.ImprimirInformações();
        empresa.RealizarVenda();

 

        Empreiteira empresa2 = new("Ada", "Rua das Amoras", 000002);
        empresa2.ImprimirInformações();
        empresa2.RealizarVenda();

    }
}
