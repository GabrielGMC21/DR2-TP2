namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se é impar ou par: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }
    }
}
