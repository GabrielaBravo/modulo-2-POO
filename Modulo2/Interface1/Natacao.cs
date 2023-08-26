using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Natacao : IExercicio
    {
        public void FazerProva()
        {
            Console.WriteLine("Realizando a Prova de Natação");
        }

        public void FazerTreino()
        {
            Console.WriteLine("Fazendo o Treino de Natação");
        }

        public void FazerFortalecimento()
        {
            Console.WriteLine("Malhando membros superiores e inferiores na natação");
        }

        public void FazerAlongamento()
        {
            Console.WriteLine("Alongando membros superiores e inferiores na natação");
        }

    }
}
