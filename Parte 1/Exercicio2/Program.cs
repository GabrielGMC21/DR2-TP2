DateTime nascimento;
Console.WriteLine("Digite a data do seu nascimento (formato: DD-MM-AAAA): ");
if (DateTime.TryParse(Console.ReadLine(), out nascimento))
{
    DateTime proximoAniversario = new DateTime(DateTime.Today.Year, nascimento.Month, nascimento.Day);

    if (proximoAniversario < DateTime.Today)
    {
        proximoAniversario = proximoAniversario.AddYears(1);
    }

    TimeSpan distancia = proximoAniversario - DateTime.Today;

    if (distancia.Days == 0)
    {
        Console.WriteLine("Seu aniversário é hoje! Parabéns!");
        return;
    }

    Console.WriteLine($"Seu próximo aniversário será em: {distancia.Days} dias");
}
else
{
    Console.WriteLine("Data inválida. Por favor, insira a data no formato correto (DD-MM-AAAA).");
    return;
}
