using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo -07 - Operador ternário
/// </summary>
/// 

namespace Operador07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Sexto: M ou F");
            string Sexo = Console.ReadLine();

            Console.WriteLine(Sexo == "M" ? "Masculino" : "Feminino");
            Console.ReadKey();
        }
    }
}
