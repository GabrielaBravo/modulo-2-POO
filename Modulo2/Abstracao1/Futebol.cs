using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao1
{
    public class Futebol : EsporteBase
    {
        public override int QuantidadeJogadoresPorTime { get; set; } = 11;
        public override int TempodeJogoEmMinutos { get; set; } = 90;

        public override string IniciarJogo()
        {
            return "O jogo foi iniciado";
        }

        public override string FinalizarJogo()
        {
            return "O jogo foi finalizado";
        }
    }
}
