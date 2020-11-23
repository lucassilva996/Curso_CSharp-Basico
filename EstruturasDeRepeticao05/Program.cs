using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 06 - Estruturas de Repetição
/// Exemplo 5 - FOREARCH
/// utilizado para percorrer arrays e listas
/// </summary>
namespace EstruturasDeRepeticao05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // "n" é a variavel criada para percorrer o array
            foreach (int n in numeros)
            {
                //o foreach repete a execução para cada elemento do array, nesse exemplo irá repetir 9 vezes
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
