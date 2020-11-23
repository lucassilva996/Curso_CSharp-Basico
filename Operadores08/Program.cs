using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo - 08
/// </summary>
/// 
namespace Operadores08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10 - 2 * 3;
            Console.WriteLine("a = 10 - 2 * 3 é igual a {0}", a);
            Console.ReadKey();
            int b = (10 - 2) * 3;
            Console.WriteLine("b = (10-2) * 3 é igual a {0}", b);
            Console.ReadKey();
        }
    }
}
