using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Notebook
    {
        public string Modelo { get; set; }
        public string MemoriaRAM { get; set; }
        public string Processador { get; set; }
        public double TamanhoTela { get; set; }

        public Notebook(string modelo, string memoriaRAM, string processador, double tamanhoTela)
        {
            Modelo = modelo;
            MemoriaRAM = memoriaRAM;
            Processador = processador;
            TamanhoTela = tamanhoTela;
        }

        public void ImprimeDados()
        {
            StringBuilder builder = new();
            builder.AppendLine("Dados do notebook");
            builder.AppendLine($"Modelo: {Modelo}");
            builder.AppendLine($"Memoria RAM: {MemoriaRAM}");
            builder.AppendLine($"Processador: {Processador}");
            builder.AppendLine($"Tamanho da tela: {TamanhoTela}");

            Console.WriteLine(builder);
        }

    }
}
