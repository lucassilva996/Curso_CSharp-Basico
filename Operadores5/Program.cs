using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo 05 - Operadores Relacionais
/// </summary>

namespace Operadores05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            bool b1, b2;
            i = 10;
            j = 11;
            if (i < j)
                Console.WriteLine("i < j");
            if (i <= j) 
                Console.WriteLine("i <= j");
            if (i != j) 
                Console.WriteLine("i != j");
            if (i == j) 
                Console.WriteLine("Não será executado");
            if (i >= j) 
                Console.WriteLine("Não será executado");
            if (i > j) 
                Console.WriteLine("Não será executado");
            Console.ReadKey();

        }
    }
}
