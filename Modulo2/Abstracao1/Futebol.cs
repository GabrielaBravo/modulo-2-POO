using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao1
{
    public class Futebol : EsporteBase
    {
        public override int QuantidadeJogadoresPorTime { get; set; }
        public override int TempoDeJogoEmMinutos { get; set; }

        public Futebol()
        {
            QuantidadeJogadoresPorTime = 11;
            TempoDeJogoEmMinutos = 90;
        }

        public override string ExibirDescricao()
        {
            return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempoDeJogoEmMinutos} minutos ";
        }
    }
}
