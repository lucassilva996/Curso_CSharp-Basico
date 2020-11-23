using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 08 - Conversão de Tipos
/// Exemplo 1 - Conversão implicita e explicita(cast)
/// </summary>
namespace ConversaoTipos01
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita
            //int i = 1230987;
            //double d = i;
            //Console.WriteLine("variavel double d = " + i);
            //Console.ReadKey();

            //conversão explicita - cast
            double d1 = 123.587;
            int i1 = (int)d1;
            decimal dec = (decimal)d1;
            Console.WriteLine("variavel int i1 = " + i1);
            Console.ReadKey();
        }
    }
}
