using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animais.Interfaces;

namespace Animais
{
    internal class Gato : IGato
    {
        public void Comer()
        {
            Console.WriteLine("Miau, Nhom nhom");
        }

        public void Miar()
        {
            Console.WriteLine("MIAUUUUUUUUUUUUUUUUUUUUUUU!");
        }

        public void Obedecer()
        {
            Console.WriteLine("miau! Ok!");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Fazendo gatinhos");
        }
    }
}
