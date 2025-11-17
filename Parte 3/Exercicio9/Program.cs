namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário bruto: ");
            double salario = double.Parse(Console.ReadLine());

            double inss = 0;
            double ir = 0;

            switch (salario)
            {
                case <= 1518:
                    inss = salario * 0.075;
                    break;
                case <= 2793.88:
                    inss = salario * 0.09;
                    break;
                case <= 4190.83:
                    inss = salario * 0.12;
                    break;
                case <= 8157.41:
                    inss = salario * 0.14;
                    break;
                default:
                    inss = 8157.41 * 0.14;
                    break;
            }

            double baseIR = salario - inss;  

            switch (baseIR)
            {
                case <= 2259.20:
                    ir = 0;
                    break;
                case <= 2826.65:
                    ir = baseIR * 0.075;
                    break;
                case <= 3751.05:
                    ir = baseIR * 0.15;
                    break;
                case <= 4664.68:
                    ir = baseIR * 0.225;
                    break;
                default:
                    ir = baseIR * 0.275;
                    break;
            }

            double salarioLiquido = salario - ir - inss;

            Console.WriteLine("\n--- Informações do Salário ---\n");
            Console.WriteLine($"Salário bruto: R$ {salario}");
            Console.WriteLine($"INSS: R$ {inss}");
            Console.WriteLine($"Base para IR: R$ {baseIR}");
            Console.WriteLine($"Imposto de Renda: {(ir > 0 ? $"R$ {ir}" : "Isento")}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido}");
        }
    }
}
