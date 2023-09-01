using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEmpresaInterface
{
    internal class Empreiteira : EmpresaBase, IEmpresa
    {
        public Empreiteira(string nome, string endereco, int cnpj) : base(nome, endereco, cnpj)
        {
        }

        public void ImprimirInformações()
        {
            StringBuilder sb = new();
            sb.AppendLine($"--------------------------------------------------------");
            sb.AppendLine($"Empresa: {Nome}");
            sb.AppendLine($"Endereço: {Endereco}");
            sb.AppendLine($"CNPJ: {Cnpj}");

            Console.WriteLine(sb);
        }

        public void RealizarVenda()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Nome} Está atualmente realizando venda de serviços!");

            Console.WriteLine(sb);
        }
    }
}
