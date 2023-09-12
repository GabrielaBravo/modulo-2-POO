using Animais;
using Animais.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IAnimal> animais = new List<IAnimal>();

        ICachorro cachorro = new Cachorro();
        animais.Add(cachorro);

        IGato gato1 = new Gato();
        animais.Add(gato1);

        IPassaro passaro = new Passaro();
        animais.Add(passaro);

        foreach(var animal in animais)
        {
            animal.Comer();
            animal.Reproduzir();
            if(animal is IGato gato2) 
            {
                gato2.Miar();
            }
            if (animal is ICachorro cachorro2)
            {
                cachorro2.Latir();
            }
            if(animal is IPassaro passaro2)
            {
                passaro2.Voar();

            }
            if (animal is IAnimalDomestico animaldomentico)
            {
                animaldomentico.Obedecer();
            }

        }

        

    }
}