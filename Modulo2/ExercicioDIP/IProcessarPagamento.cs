using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public interface IProcessarPagamento
    {
        bool ProcessarPagamento()
        {
            Console.WriteLine("Pagamento com cartão de crédito realizado com sucesso!");
            return true;
        }
        
    }
}
