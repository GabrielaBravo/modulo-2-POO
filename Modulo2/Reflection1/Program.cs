using System;
using System.Reflection;
using System.Linq;

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
    public static string RetornaNome(object obj)
    {
        var tipo = obj.GetType();

        return tipo.Name;

    }
}


//Utilizando Reflections, além de termos a possibilidade de selecionar membros específicos de uma classe em tempo de execução, podemos retornar todos os membros públicos da mesma (propriedade, campos e metodos).

//Considerando a classe a seguir, crie uma classe estática chamada Reflections e nessa classe crie um método estático com o nome de RetornaMembrosPublicos. Este método receberá um objeto (tipo object) e retornará uma lista de strings com os nomes dos membros públicos (propriedade, campos e metodos) pertencentes à esse objeto.

//public class AlgumaClasse
//{
//    public int CampoX;
//    private int CampoY;
//    public int Propriedade1 { get; set; }
//    private int Propriedade2 { get; set; }

//    public string Metodo1()
//    {
//        return "Método1 chamado";
//    }

//    public string Metodo2()
//    {
//        return "Metodo2 chamado";
//    }
//}
//Exemplo:

//Reflections.RetornaMembrosPublicos(new AlgumaClasse())
//Lembre - se:

//Coloque o código da classe AlgumaClasse na sua solução.
//Como toda classe herda da classe object, o retorno desse método conterá métodos que fazem parte dessa classe, são eles: GetType, ToString, GetHashCode e Equals