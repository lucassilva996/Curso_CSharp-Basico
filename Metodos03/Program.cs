using System;

namespace Metodos03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 100;
            int numero1;
            //Console.WriteLine("Valor original de numero: {0} ", numero);
            //CalculaValor_PorValor(numero);
            //CalculaValor_PorReferencia(ref numero);
            Console.WriteLine("A Variavel numero1 não foi inicializada");
            CalculaValor_PorReferencia_Out(out numero1);
            Console.WriteLine("Valor apos chamar o metodo de numero: {0} ", numero1);
            Console.ReadKey();
        }

        public static void CalculaValor_PorValor(int valor)
        {
            valor = valor * 10;
        }
        public static void CalculaValor_PorReferencia(ref int valor)
        {
            valor = 5;
            valor = valor * 10;
        }

        public static void CalculaValor_PorReferencia_Out(out int valor)
        {
            valor = 5;
            valor = valor * valor;
        }
    }

    public class Teste
    {
        public static void metodoTeste()
        {

        }
    }
}
