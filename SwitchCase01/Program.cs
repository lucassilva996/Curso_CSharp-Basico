using System;


/// <summary>
/// Curso C# - Módulo Básico
/// Aula 07 - Switch/Case
/// Exemplo 01
/// </summary>

namespace SwitchCase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero e tecle algo...");
            int numero = int.Parse(Console.ReadLine());

            switch(numero)
            {
                case 10:
                    Console.WriteLine("O número é: " + numero);
                    break;
                case 20:
                    Console.WriteLine("O número é: " + numero);
                    break;
                case 30:
                    Console.WriteLine("O número é: " + numero);
                    break;
                default:
                    Console.WriteLine("O número não é 10, 20 ou 30");
                    break;
            }
            Console.ReadKey();
        }
    }
}
