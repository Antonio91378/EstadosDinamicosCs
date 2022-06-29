using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }
        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("É impossível ir para finalizado diretamente do estado atual.");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
