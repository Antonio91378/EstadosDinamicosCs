using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    internal class Aprovado : EstadoDeUmOrcamento
    {
        public int QntMaxDeDesconto { get ; set; }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            QntMaxDeDesconto ++;
            if (QntMaxDeDesconto <= 1)
            {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
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
