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
        public abstract int TempoDeJogoEmMinutos { get; set; }

        public string IniciarJogo()
        {
            return "O jogo foi iniciado";
        }
        public string FinalizarJogo()
        {
            return "O jogo foi finalizado";
        }
        public abstract string ExibirDescricao();

    }
}
