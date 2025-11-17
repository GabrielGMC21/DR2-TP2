namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1, 101);

            int numeroUsuario = 0;

            do
            {
                Console.Write("Digite um número entre 1 e 100: ");
                numeroUsuario = int.Parse(Console.ReadLine());

                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine($"O número aleatório é menor que {numeroUsuario}");
                }
                else if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine($"O número aleatório é maior que {numeroUsuario}");
                }

            }
            while (numeroAleatorio != numeroUsuario);

            Console.Clear();
            Console.WriteLine($"Parabéns! O número era: {numeroAleatorio}");
        }
    }
}
