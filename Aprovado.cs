using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    internal class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orcamento ja esta neste estado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orcamento ja foi aprovado");
        }
    }
}
