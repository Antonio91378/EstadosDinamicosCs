namespace DesignPatternState
{
    public class program
    {
        // Exercicio usando Design Pattern State
        static void Main(string[] args)
        {
            var reforma = new Orcamento();
            reforma.Valor = 500;
            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            reforma.AplicaDescontoExtra();
            //dara uma excecao, como solicitado
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();
        }
    }
}