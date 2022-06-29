using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    public class Orcamento

    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
   
        public Orcamento()
        {
            this.EstadoAtual = new EmAprovacao();
        }
        public void AdicionaValor(double valor)
        {
            this.Valor += valor;

        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
