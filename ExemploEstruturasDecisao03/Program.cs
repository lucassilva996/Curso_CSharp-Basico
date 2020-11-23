using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 05 - Estruturas de Decisão
/// Exemplo 3 - Switch Case
/// </summary>

namespace ExemploEstruturasDecisao03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            switch(numero)
            {
                case 0:
                    Console.WriteLine("O numero é zero");
                    break;
                case 1:
                    Console.WriteLine("O numero é um");
                    break;
            }
            Console.ReadKey();
        }
    }
}
