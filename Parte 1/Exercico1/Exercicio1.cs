using System.ComponentModel;
using System.Data;

namespace DR2_TP2.Parte_1
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            DateTime nascimento;
            Console.WriteLine("Digite a data do seu nascimento (formato: DD-MM-AAAA): ");
            
            if(!DateTime.TryParse(Console.ReadLine(), out nascimento))
            {
                Console.WriteLine("Data inválida. Por favor, insira a data no formato correto (DD-MM-AAAA).");
                return;
            }

            DateTime hoje = DateTime.Today;

            int anos = hoje.Year - nascimento.Year;
            int meses = hoje.Month - nascimento.Month;
            int dias = hoje.Day - nascimento.Day;

            if (dias < 0)
            {
                meses--;
                DateTime mesAnterior = hoje.AddMonths(-1);
                dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            if (nascimento.Month == 2 && nascimento.Day == 29 && (hoje.Month < 2 || (hoje.Month == 2 && hoje.Day < 29)))
            {
                anos--;
            }

            Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.");      
        }
    }
}
