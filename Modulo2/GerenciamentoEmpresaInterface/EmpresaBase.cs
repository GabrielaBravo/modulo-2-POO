using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEmpresaInterface
{
    internal class EmpresaBase
    {
        public int Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }

        public EmpresaBase(string nome, string endereco, int cnpj)
        {
            Cnpj = cnpj;
            Endereco = endereco;
            Nome = nome;
        }
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"--------------------------------------------------------");
            Console.WriteLine($"Empresa: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"CNPJ: {Cnpj}");
        }

    }
}
