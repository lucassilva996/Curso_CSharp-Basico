using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 09 - Lógica de Programação
/// Exercicio 2 - Menor Numero
/// </summary>
namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            MenorNumero();
        }

        public static void MenorNumero()
        {
            int Numero1, Numero2, Numero3, MenorNumero;

            Console.WriteLine("Digite o primeiro numero: ");
            Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro numero: ");
            Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro numero: ");
            Numero3 = int.Parse(Console.ReadLine());

            if (Numero1 < Numero2 && Numero1 < Numero3)
            {
                MenorNumero = Numero1;
                Console.WriteLine("O Primeiro numero é o menor: " + MenorNumero);
            } 
            else if (Numero2 < Numero3) 
            {
                MenorNumero = Numero2;
                Console.WriteLine("O Segundo numero é o menor: " + MenorNumero);
            }
            else
            {
                MenorNumero = Numero3;
                Console.WriteLine("O terceiro numero é o menor: " + MenorNumero);
            }
        }
    }
}
