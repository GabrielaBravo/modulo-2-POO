using System;
using System.Runtime.ConstrainedExecution;

//Considerando a classe abstrata AnimalBase e a classe Cachorro, realize a conversão da classe abstrata para uma interface chamada IAnimal.Essa nova interface deverá ser implementada pela classe Cachorro.
public interface IAnimal
{
    public abstract void comer(string comida);
    public abstract void dormir();
    public abstract string emitirSom();
}

public class Cachorro : IAnimal
{
    public string nome { get; set; }
    public string raca { get; set; }

    public  void comer(string comida) { }
    public  void dormir() { }
    public  string emitirSom() { return "AuAu"; }
}