class Program
{
    static void Main()
    {
        Console.WriteLine("Questão 4 – Conversão Segura com TryParse");
        Console.Write("Digite um número: ");
        
        string entrada = Console.ReadLine();
        
        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine($"Número digitado: {numero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }
}