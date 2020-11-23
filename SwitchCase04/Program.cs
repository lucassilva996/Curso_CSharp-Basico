using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 07 - Switch/Case
/// Exemplo 4
/// </summary>

namespace SwitchCase04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Digite um numero...");
            int.TryParse(Console.ReadLine(), out numero);
            
            switch(numero)
            {
                case 10:
                    Console.WriteLine("Você digitou: 10");
                    break;
                case 20:
                    Console.WriteLine("Você digitou: " + numero);
                    //goto case 30;  ---> Comanod goto é utilizado para algumas situações em especifico 
                    break;
                case 30:
                    Console.WriteLine("Você digitou: 30");
                    break;
                default:
                    Console.WriteLine("Você não digitou nem 10,20 ou 30");
                    break;
            }
            Console.ReadKey();
        }
    }
}
