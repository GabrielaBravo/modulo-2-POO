using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEmpresaInterface
{
    internal interface IEmpresa
    {
        public void ImprimirInformacoes();

        public abstract void RealizarVenda();
    }
}
