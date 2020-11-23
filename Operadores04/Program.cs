using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo 04 - Operadores de Incremento Prefixo e Sufixo
/// </summary>
namespace Operadores04
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores de incremento prefixo e sufixo.
            //*OBS = Esses operadores também são válidos para decremento.
            int valor1;
            int valor2 = 1000;
            valor1 = ++valor2; //primeiro incrementa depois atribui
            Console.WriteLine("Valor1 {0} ", valor1);
            Console.WriteLine("Valor2 {0} ", valor2);
            Console.ReadKey();

            int valor3;
            int valor4 = 2000;
            valor3 = valor4++; //primeiro atribui depois incrementa
            Console.WriteLine("Valor3 {0} ", valor3);
            Console.WriteLine("Valor4 {0} ", valor4);
            Console.ReadKey();
        }
    }
}
