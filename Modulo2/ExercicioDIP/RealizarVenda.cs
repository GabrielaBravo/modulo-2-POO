using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    internal class RealizarVenda
    {

        //public ProcessarPagamentoCartaoCredito ProcessarPagamentoCartaoCredito { get; set; }
        //public RealizarVenda(ProcessarPagamentoCartaoCredito processarPagamento)
        //{
        //    ProcessarPagamentoCartaoCredito = processarPagamento;
        //}

        IProcessarPagamento processarPagamento1 = new ProcessarPagamentoCartaoCredito();
        public RealizarVenda(IProcessarPagamento processarPagamento1)
        {
            this.processarPagamento1 = processarPagamento1;
        }

        public void ConcluirVenda()
        {
            
            
        }
    }
}
