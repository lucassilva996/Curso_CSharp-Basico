using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 05 - Estruturas de Decisão
/// Exemplo 4 - Switch Case
/// </summary>

namespace ExemploEstruturasDecisao04
{
    class Program
    {
        static void Main(string[] args)
        {
            string carro;
            string fabrica;

            System.Console.Write("Informe a marca do seu carro: ");
            carro = Console.ReadLine();

            switch(carro)
            {
                case "Civic":
                case "Fit":
                case "City":
                    fabrica = "Honda";
                    break;
                case "Focus":
                case "Fiesta":
                    fabrica = "Ford";
                    break;
                case "Corolla":
                    fabrica = "Toyota";
                    break;
                default:
                    fabrica = "Desconhecido";
                    break;
            }
            Console.WriteLine("O Fabricante do seu carro é: {0}", fabrica);
            Console.ReadKey();
        }
    }
}
