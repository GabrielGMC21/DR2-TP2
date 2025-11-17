namespace Exercicio4
{
    internal class exercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Formulário -----");
            
            Console.Write("\nDigite Seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu número (DDD - XXXXX-XXXX): ");
            string telefone = Console.ReadLine();

            Console.Write("Digite seu e-mail (xxxx@xxxxx.com): ");
            string email = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("--- Suas informações: ----\n");

            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nTelefone: {telefone}\nE-mail: {email}\n11");

            Console.WriteLine("--- Suas informações: ----");

        }
    }
}
