using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEmpresas
{
    internal class Varejo : Empresa
    {
        public Varejo(string nome, string endereco, int cnpj) : base(nome, endereco, cnpj)
        {

        }

        public override void RealizarVenda()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Nome} Está atualmente realizando venda de produtos!");
            
            Console.WriteLine(sb);
        }
    }
}
