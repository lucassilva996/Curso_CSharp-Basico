using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 08 - Conversão de Tipos
/// Exemplo 2 - Conversão usando o método Convert
/// </summary>
namespace ConversaoTipos02
{
    class Program
    {
        static void Main(string[] args)
        {

            //convertendo strings usando o método Convert
            string numero = "2000";
            int valor1 = Convert.ToInt32(numero);
            short valor2 = Convert.ToInt16(numero);
            double valor3 = Convert.ToDouble(numero);
            DateTime data = Convert.ToDateTime("19/11/2020");
            Console.WriteLine("Usando Convert.ToXXXX");
            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n", valor1, valor2, valor3, data);
            Console.ReadKey();

        }
    }
}
