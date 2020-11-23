using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo 01 - Operadores Aritiméticos
/// </summary>
namespace Operadores01
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores aritméticos: +, -, *, / e %

            int a = 10;
            int b = 20;
            int resultado;

            resultado = a + b;
            Console.WriteLine("Soma a+b {0} ", resultado);
            resultado = a - b;
            Console.WriteLine("Soma a-b {0} ", resultado);
            resultado = a * b;
            Console.WriteLine("Soma a*b {0} ", resultado);
            resultado = a / b;
            Console.WriteLine("Soma a/b {0} ", resultado);
            resultado = a % b;
            Console.WriteLine("Soma a%b {0} ", resultado);
            Console.WriteLine("10 elevado a 5 = {0} ", Math.Pow(10,5));
            Console.WriteLine("Raiz quadrada de 121 = {0} ", Math.Sqrt(121));

            Console.ReadKey();

        }
    }
}
