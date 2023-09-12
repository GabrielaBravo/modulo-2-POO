using Animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Cachorro : ICachorro
    {
        public void Comer()
        {
            Console.WriteLine("AuAu! Nhom nhom");
        }

        public void Latir()
        {
            Console.WriteLine("AU AU!");
        }

        public void Obedecer()
        {
            Console.WriteLine("Au, Ok!");
        }

        public void Reproduzir()
        {
            Console.WriteLine("fazendo cachorrinhos!");
        }
    }
}
