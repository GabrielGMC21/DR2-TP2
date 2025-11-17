namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                if (numero == 0)
                {
                    Console.WriteLine(numero);
                    numero--;
                    continue;
                }

                Console.Write(numero + ", ");
                numero--;
            }
        }
    }
}
