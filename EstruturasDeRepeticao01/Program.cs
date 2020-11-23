using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 06 - Estruturas de Repetição
/// Exemplo 1 - Goto (Menos usado)
/// </summary>

namespace EstruturasDeRepeticao01
{
    class Program
    {
        static void Main(string[] args)
        {
            //estrutura de repetição
            //goto

            int i = 0;
        repetir:
            Console.WriteLine("i = {0}", i);
            i++; //i=i+i
            if (i < 10)
                goto repetir;

            Console.ReadKey();
        }
    }
}
