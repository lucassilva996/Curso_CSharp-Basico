using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 07 - Switch/Case
/// Exemplo 3 - Switch Case com Enum
/// </summary>
namespace SwitchCase03
{
    class Program
    {
        public enum Volume
        {
            Baixo,
            Medio,
            Alto
        }
        static void Main(string[] args)
        {
            Volume volume = Volume.Medio;
                
            switch(volume)
            {
                case Volume.Baixo:
                    Console.WriteLine("O volume está baixo");
                    break;
                case Volume.Medio:
                    Console.WriteLine("O volume está médio");
                    break;
                case Volume.Alto:
                    Console.WriteLine("O volume está alto");
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
