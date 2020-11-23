using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 06 - Estruturas de Repetição
/// Exemplo 4 - FOR
/// </summary>

namespace EstruturasDeRepeticao04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=50; i > 0; i--)
            {
                //for executa as repetições apenas no numero de vezes definidas no scopo do for
                //no caso o valor de repetições deve ser definido na variavel i do scopo.
                Console.Write("{0} ", i);

                if (i%10 == 0 )
                {
                    // \t é o caractere de tabulação
                    Console.WriteLine("\t\t {0} ", i); 
                }
            }
            Console.ReadKey();
        }
    }
}
