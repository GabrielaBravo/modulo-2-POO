using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    internal class ProcessarPagamentoPaypal : IProcessarPagamento
    {
        public bool ProcessarPagamento()
        {
            Console.WriteLine("Pagamento com Paypal realizado com sucesso!");
            return true;
        }


    }
}
