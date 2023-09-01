using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEmpresas
{
    public abstract class Empresa
    {

        public int Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }

        public Empresa(string nome, string endereco, int cnpj)
        {
            Cnpj = cnpj;
            Endereco = endereco;
            Nome = nome;
        }
        public void ImprimirInformações()
        {
            StringBuilder sb = new();
            sb.AppendLine($"--------------------------------------------------------");
            sb.AppendLine($"Empresa:{Nome}");
            sb.AppendLine($"Endereço: {Endereco}");
            sb.AppendLine($"CNPJ: {Cnpj}");

            Console.WriteLine(sb);
        }

        public abstract void RealizarVenda();

    }
}
