using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 08 - Conversão de Tipos
/// Exemplo 3 - Conversão usando o método Parse
/// </summary>
namespace ConversaoTipos03
{
    class Program
    {
        static void Main(string[] args)
        {
            //convertendo strings usando o método Parse
            //string para inteiro
            //string numero = "2000";

            //int valor1 = int.Parse(numero);
            //short valor2 = short.Parse(numero);
            //double valor3 = double.Parse(numero);
            //DateTime data = DateTime.Parse("19/11/2020");
            //Console.WriteLine("Usando tipo.Parse");
            //Console.WriteLine("{0}\n {1}\n {2}\n {3}\n", valor1, valor2, valor3, data);
            //Console.ReadKey();

            //metodo ToString é utilizado para converter qualquer tipo para string
            //inteiro para string
            int i = 100;
            string valor = i.ToString();
            string valor2 = Convert.ToString(i);
            Console.WriteLine("Valor da string= " + valor);
            Console.WriteLine("Valor da string= " + valor2);
            Console.ReadKey();
        }
    }
}
