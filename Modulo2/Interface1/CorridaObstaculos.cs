using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class CorridaObstaculos : IExercicio
    {
        public void FazerProva()
        {
            Console.WriteLine("Realizando a Prova de Corrida de Obstáculos");
        }

        public void FazerTreino()
        {
            Console.WriteLine("Fazendo o Treino de Corrida de Obstáculos");
        }

        public void FazerFortalecimento()
        {
            Console.WriteLine("Malhando membros inferiores na corrida de obstáculos");
        }

        public void FazerAlongamento()
        {
            Console.WriteLine("Alongando membros inferiores na corrida de obstáculos");
        }
    }
}
