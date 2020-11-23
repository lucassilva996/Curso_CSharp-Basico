using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 05 - Estruturas de Decisão
/// Exemplo 2 - IF aninhado
/// </summary>

namespace ExemploEstruturasDecisao02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Informe um número entre 0 e 10:");
            //parse faz a conversão de uma string para um numero
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("O número deve estar entre 0 e 10");

            }
            else if(numero == 5)
            {
                if (numero < 3)
                {
                    Console.WriteLine("O número deve ser maior que zero");
                }
                else
                {

                    Console.WriteLine("O numero digitado foi {0}", numero);
                }
            }
            Console.ReadLine();
        }
    }
}
