using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 06 - Estruturas de Repetição
/// Exemplo 2 - While
/// </summary>

namespace EstruturasDeRepeticao02
{
    class Program
    {
        static void Main(string[] args)
        {
            //estrutura while
            int i = 0; //se i for maior que o while o código não será executado
            while (i<10)
            {
                Console.WriteLine("i = {0}", i);
                i++; // é igual a i=i+1
            }
            Console.ReadKey();
        }
    }
}
