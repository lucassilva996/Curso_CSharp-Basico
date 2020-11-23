using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 09 - Lógica de Programação
/// Exercicio 1 - Média de Notas
/// </summary>
namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CalculaMedia();
        }

        public static void CalculaMedia()
        {
            int Nota1, Nota2, Nota3, Nota4, Media;

            Console.WriteLine("Digite a primeira nota: ");
            Nota1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite a segunda nota: ");
            Nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            Nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            Nota4 = int.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            Console.WriteLine("A média das notas é: " + Media);
            Console.ReadKey();
        }
    }
}
