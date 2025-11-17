namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            switch (imc)
            {
                case < 18.5:
                    Console.WriteLine("Você está abaixo do peso");
                    break;
                case < 24.9:
                    Console.WriteLine("Você está no peso normal");
                    break;
                case < 29.9:
                    Console.WriteLine("Você está sobrepeso");
                    break;
                case < 34.9:
                    Console.WriteLine("Você está em obesidade Grau 1");
                    break;
                case < 39.9:
                    Console.WriteLine("Você está em obesidade Grau 2");
                    break;
                case > 40:
                    Console.WriteLine("Você está em obesidade Grau 3");
                    break;

            }
        }
    }
}
