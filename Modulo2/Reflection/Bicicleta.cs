using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Bicicleta
    {
        public string Modelo { get; set; }
        public int QuantidadeMarchas { get; set; }
        public int TamanhoAro { get; set; }
        public int TamanhoQuadro { get; set; }
        public string TipoQuadro { get; set; }

        public Bicicleta(string modelo, int quantidadeMarchas, int tamanhoAro, int tamanhoQuadro, string tipoQuadro)
        {
            Modelo = modelo;
            QuantidadeMarchas = quantidadeMarchas;
            TamanhoAro = tamanhoAro;
            TamanhoQuadro = tamanhoQuadro;
            TipoQuadro = tipoQuadro;
        }

        public void TrocarMarcha()
        {

        }

        public void Freiar()
        {

        }

        public void Pedalar()
        {

        }

        public void ImprimeDados()
        {
            StringBuilder builder = new();
            builder.AppendLine("Dados da bicicleta:");
            builder.AppendLine($"Modelo: {Modelo}");
            builder.AppendLine($"Quantidade Marchas: {QuantidadeMarchas}");
            builder.AppendLine($"Tamanho Aro: {TamanhoAro}");
            builder.AppendLine($"Tamanho Quadro: {TamanhoQuadro}");
            builder.AppendLine($"Tipo Quadro: {TipoQuadro}");

            Console.WriteLine(builder);
        }
    }
}