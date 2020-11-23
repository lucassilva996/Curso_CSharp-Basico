using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 05 - Estruturas de Decisão
/// Exemplo 1
/// </summary>

namespace ExemploEstruturasDecisao01
{
    class Program
    {
        static void Main(string[] args)
        {
            //estruturas de decisão 
            //if 
            //bool valor = true;
            //if (valor == true)
            //    //System.Console.WriteLine("valor é = " + valor);
            //    System.Console.WriteLine("valor é {0} {1} {2}", valor, valor, valor);
            //    //Pausa a execução
            //    System.Console.ReadKey();

            int a, b, c;
            a = 7;
            b = 7;
            //a=b=c=5;
            if (a < b)
            {
                Console.WriteLine("A é menor que B");
                Console.WriteLine("Valor de a = {0} ", a);
                Console.WriteLine("Valor de b = {0} ", b);
            }
            else if (a > b)
            {
                Console.WriteLine("A é maior que B");
                Console.WriteLine("Valor de a = {0} ", a);
                Console.WriteLine("Valor de b = {0} ", b);
            }
            else
            {
                Console.WriteLine("A é igual a B");
                Console.WriteLine("Valor de a = {0} ", a);
                Console.WriteLine("Valor de b = {0} ", b);
            }
            Console.ReadLine();
         }
           
    }
}
