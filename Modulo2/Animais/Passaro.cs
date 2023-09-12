using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animais.Interfaces;

namespace Animais
{
    internal class Passaro : IPassaro
    {
        public void Comer()
        {
            Console.WriteLine("piu piu!nhom nhom");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Estou botando ovinhos");
        }

        public void Voar()
        {
            Console.WriteLine("Estou voando!"); ;
        }
    }
}
