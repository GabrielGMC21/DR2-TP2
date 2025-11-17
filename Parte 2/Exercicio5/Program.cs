namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma temperatura em Celsius para ser transformado em Fahrenheit e Kelvin: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = Math.Round(celsius * 9 / 5 + 32, 2);
            double kelvin = Math.Round(celsius + 273.15, 2);

            Console.WriteLine($"{celsius} graus Celsius são\nFahrenheit: {fahrenheit}\nKelvin: {kelvin}");
        }
    }
}
