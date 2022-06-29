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
            reforma.Aprova();
            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();
            reforma.AplicaDescontoExtra();
        }
    }
}