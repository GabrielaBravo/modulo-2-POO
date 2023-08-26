using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public interface IExercicio
    {
         void FazerFortalecimento();
         void FazerAlongamento();
        void FazerProva()
        {
            Console.WriteLine("Realizando a Prova");
        }
        void FazerTreino()
        {
            Console.WriteLine("Fazendo o Treino");
        }
    }
}
