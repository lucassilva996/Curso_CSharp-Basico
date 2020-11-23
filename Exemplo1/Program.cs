/// <summary>
/// Curso C# - Módulo Básico
/// Aula 02 - Variáveis e Tipos (1º Aula Prática)
/// Exemplo 1
/// </summary>

using System;

namespace Exemplo1
{
    class Program
    {
        static void Main()
        {
            int x; //declara uma váriavel inteira identificada como x
            int y; //declara uma váriavel inteira identificada como y

            x = 100; //<--- declaração do valor da váriavel
            Console.WriteLine("X contém o valor: " + x); //<--- Exibir o valor em tela através do método writeline da classe Console
            y = x / 2; //<--- declaração do valor da váriavel
            x = y + 100;

            Console.WriteLine("Y contém o valor de X/2 = " + y);
            Console.WriteLine("X contém o valor de Y + 100 = " + x);
            Console.ReadKey(); //<--- Método faz com que a aplicação aguarde uma ação do usuário.


        }
    }
}
