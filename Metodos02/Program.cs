using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 14 - Métodos e Funções
/// Exemplo - 02 
/// </summary>
/// 
namespace Metodos02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estou no método Main() e vou chamar o método ImprimeMensagem()");
            imprimeMensagem();
            Console.WriteLine("Acabei de chamar o método ImprimeMensagem()");

            int valor1 = 100;
            int valor2 = 200;
            int soma = calculaSoma(valor1, valor2);
            Console.WriteLine("Vou calcular a soma de dois inteiros: ");
            Console.WriteLine("O valor da soma é: " + soma);
            Console.ReadKey();

        }

        public static void imprimeMensagem()
        {
            Console.WriteLine("Sou um método que não retorna nada");
        }

        public static int calculaSoma(int v1, int v2)
        {
            int soma = v1 + v2;
            return soma;
            //return v1 + v2;
        }
    }
}
