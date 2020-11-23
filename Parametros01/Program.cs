using System;
using System.Runtime.InteropServices;


//Um parametro ele representa um nome do valor que o procedimento espera receber quando for chamado
//quando defino o método teste void Teste(int x, int y) //x e y são parâmetros
//Argumentos são os valores que você passa para o para um parâmetro nomeado no procedimento(metodo) exemplo -  x = 1, y= 20.
namespace Parametros01
{
    class Program
    {
        //nesta classe foi realizada uma sobrecarga de métodos
        //Sobrecarga (Overload)  é a habilidade de poder definir diversas propriedades, métodos ou procedimentos em uma classe com o mesmo nome mas parâmetros diferentes.
        static void Main(string[] args)
        {
            Somar(10, 20);
            Somar(10, 20, new int[] { 30, 40, 50 });
            Console.ReadKey();
        }

        //public static void Somar(int n1, int n2)
        //{
        //    Somar(n1, n2, null);
        //}

        //possibilidade de usar a palavra chave params, ela sempre é o ultimo parametro da lista
        //public static void Somar(int n1, int n2, params int[] numeros)
        // Named Params - public static void Somar(int n1, int n2, int[] numeros = null)
        //optional params
        public static void Somar(int n1, int n2, [Optional]int[] numeros)
        {
            int resultado = n1 + n2;
            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }
            System.Console.WriteLine("Soma = " + resultado);
        }
    }
}
