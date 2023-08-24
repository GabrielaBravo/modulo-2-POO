using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao1
{
    public abstract class EsporteBase
    {
        public abstract int QuantidadeJogadoresPorTime { get; set; }
        public abstract int TempodeJogoEmMinutos { get; set; }

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public string ExibirDescricao()
        {
            return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempodeJogoEmMinutos} minutos";
        }
    }

}
