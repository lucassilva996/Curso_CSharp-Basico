/// <summary>
/// Curso C# - Módulo Básico
/// Aula 02 - Variáveis e Tipos (1º Aula Prática)
/// Exemplo 3 - Utilização de Strings
/// </summary>
using System;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome = "Lucas";
            string sobreNome = "Lima";

            int a = 10;
            int b = 40;

            Console.WriteLine("O seu nome completo é " + primeiroNome + " " + sobreNome);
            Console.WriteLine("O valor de A + B é igual a: " + (a + b));
            Console.ReadKey();
        }
    }
}
