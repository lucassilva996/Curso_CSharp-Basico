using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 06 - Estruturas de Repetição
/// Exemplo 3 - Do While
/// </summary>

namespace EstruturasDeRepeticao03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("i = {0}", i);
                i--;
            } while (i > 0); //enquanto i for maior q 0 ele será executado até o 1
            Console.ReadKey();
        }
    }
}
