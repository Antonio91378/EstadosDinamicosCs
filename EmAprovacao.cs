using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public int QntMaxDeDesconto { get; set; }
        
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            QntMaxDeDesconto++;
            if (QntMaxDeDesconto <= 1)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
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
