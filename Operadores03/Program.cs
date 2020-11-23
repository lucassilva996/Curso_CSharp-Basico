using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo 03
/// </summary>
namespace Operadores03
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores ++ e --
            int i = 1000;
            i++; //i=i+1
            Console.WriteLine("Salario i++ = {0}", i);
            i--; //i=i-1
            Console.WriteLine("Salario i-- = {0}", i);
            Console.ReadKey();
        }
    }
}
