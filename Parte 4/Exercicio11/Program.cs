namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para exiber sua tabuada de 1 a 10: ");
            double numero = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }
    }
}
