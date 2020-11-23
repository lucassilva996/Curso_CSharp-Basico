using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 13 - Namespaces
/// Exemplo - 01 
/// </summary>
/// 
namespace Brasil
{
    class Program
    {
        static void Main(string[] args)
        {
            Lucas.Saudacao.BemVindo();
            Console.ReadKey();
        }
    }

    namespace Lucas
    {
        class Saudacao
        {
            public static void BemVindo()
            {
                Console.WriteLine("Bem-Vindos");
            }
        }
    }
}
