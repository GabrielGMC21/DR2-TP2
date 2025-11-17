using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime data1;
        DateTime data2;
        Console.Write("Digite a primeira data (dd/MM/yyyy): ");

        if (!DateTime.TryParse(Console.ReadLine(), out data1))
        {
            Console.WriteLine("Data inválida. Por favor, insira a data no formato correto (DD-MM-AAAA).");
            return;
        }

        Console.Write("Digite a segunda data (dd/MM/yyyy): ");

        if (!DateTime.TryParse(Console.ReadLine(), out data2))
        {
            Console.WriteLine("Data inválida. Por favor, insira a data no formato correto (DD-MM-AAAA).");
            return;
        }

        if (data1 > data2)
        {
            var temp = data1;
            data1 = data2;
            data2 = temp;
        }

        TimeSpan diferencaDias = data2 - data1;

        int anos = data2.Year - data1.Year;
        int meses = data2.Month - data1.Month;
        int dias = data2.Day - data1.Day;

        if (dias < 0)
        {
            meses--;
            DateTime mesAnterior = data2.AddMonths(-1);
            dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        Console.WriteLine($"Intervalo: {anos} ano(s), {meses} mes(es) e {dias} dia(s)");
    }
}
