using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 11 - Operadores
/// Exemplo 06 - Operadores Lógicos: &&, ||, !
/// </summary>
/// 
namespace Operador06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            n = 10;
            d = 2;

            //d é diferente de zero e 10 % 2 tem resto igual a zero
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " é o fator de " + n);
            Console.ReadKey();

            d = 0; //agora definimos d igual a zero
            //Como d é zero o segundo termo não é avaliado
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " é o fator de " + n);
            else
                Console.WriteLine("Não avaliou o segundo termo");
            Console.ReadKey();

            //Agora vamos usar o operador &
            //Vai ocorrer uma divisão por zero pois o segundo termo será avaliado ( n % d )
            if (d != 0 & (n % d) == 0)
                Console.WriteLine(d + " é o fator de " + n);
            else
                Console.WriteLine("Avaliou o segundo termo e causou uma divisão por zero " + " Não vai executar pois não tratamos o erro");

            Console.ReadKey();
        }
    }
}
