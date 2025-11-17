namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua nota (0 - 10) : ");
            int nota = int.Parse(Console.ReadLine());

            switch (nota) {
                case < 5:
                    Console.WriteLine("Sua nota é insuficiente");
                    break;
                case < 7:
                    Console.WriteLine("Sua nota é regular");
                    break;
                case < 9:
                    Console.WriteLine("Sua nota é bom");
                    break;
                case >= 9:
                    Console.WriteLine("Sua nota é excelente");
                    break;
            };            
        }
    }
}
