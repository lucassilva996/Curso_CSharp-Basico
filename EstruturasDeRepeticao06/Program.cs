using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 06 - Estruturas de Repetição
/// Exemplo 6 - Comandos Break e Continue
/// </summary>
namespace EstruturasDeRepeticao06
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Informe um numero: ");
                int valor = int.Parse(Console.ReadLine());
                if ((valor % 3 ) == 0)
                {
                    //examina e continua o inicio da repetição
                    continue;
                }
                if ((valor % 5 ) == 0)
                {
                    //encerra o inicio da repetição
                    break;
                }
                Console.WriteLine("O numero não divisivel por 3 ou 5");
                
            }
            Console.WriteLine("O numero é divisivel por 5");
            Console.ReadKey();
        }
    }
}
