using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Interfaces
{
    internal interface ICachorro : IAnimal
    {
        public void Comer()
        {
            Console.WriteLine("Nhom nhom");
        }

        public void Latir()
        {
            Console.WriteLine("AU AU!");
        }

        public void Obedecer()
        {
            Console.WriteLine("Ok!");
        }

        public void Reproduzir()
        {
            Console.WriteLine("fazendo filhotes!");
        }


    }
}
