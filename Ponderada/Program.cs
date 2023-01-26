using System;

namespace Ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float primeiraNota, segundaNota, terceiraNota, media;

            Console.WriteLine("Digite a Primeira Nota: ");
            primeiraNota = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a Segunda Nota: ");
            segundaNota = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a Terceira Nota: ");
            terceiraNota = float.Parse(Console.ReadLine());
            Console.Clear();

            media = (2 * primeiraNota + 3 * segundaNota + 5 * terceiraNota) / 10 ;

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("A média ponderada é: " + media);
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
