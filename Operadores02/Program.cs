using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo 02 - Operadores de Atribuição
/// </summary>
namespace Operadores02
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario = 1000;
            salario += 100; //incremento - adiciona 100$ ao salario
            Console.WriteLine("Salario += " + salario);
            salario -= 100; //decremento - tira 100$ ao salario
            Console.WriteLine("Salario -= " + salario);
            salario *= 100; //Multiplica o salario x 100
            Console.WriteLine("Salario *= " + salario);
            salario /= 100; //Divide o salario por 100
            Console.WriteLine("Salario /= " + salario);
            salario %= 100; //salario = salario%100
            Console.WriteLine("Salario %= " + salario);
            Console.ReadKey();
        }
    }
}
