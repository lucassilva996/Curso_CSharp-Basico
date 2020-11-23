using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 07 - Switch/Case
/// Exemplo 02
/// </summary>


namespace SwitchCase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno {A,B,C,D ou F}!");
            //variavel nota é um char
            //char.Parse converte o char em string para exibição
            //ToUpper faz com que caso seja digitado minusculo, ele exiba maiusculo.
            char nota = char.Parse(Console.ReadLine().ToUpper());

            switch(nota)
            {
                case 'A':
                    Console.WriteLine("Excelente!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Muito bom!");
                    break;
                case 'D':
                    Console.WriteLine("O aluno foi para recuperação");
                    break;
                case 'F':
                    Console.WriteLine("O aluno foi reprovado");
                    break;
                default:
                    Console.WriteLine("O aluno foi reprovado");
                    break;
            }
            Console.WriteLine("Nota do Aluno: {0}", nota);
        }
    }
}
