/// <summary>
/// Curso C# - Módulo Básico
/// Aula 03 - Nullable Types
/// Exemplo 2
/// </summary>
using System;

namespace ExemploNullableTypes2
{
    class Program
    {
        static void Main(string[] args)
        {

            //HasValue = Usamos as propriedades somente de leitura.
            //A propriedade HasValue retorna true se a variável contém um valor, ou false se ele é nulo.

            //Value = A propriedade value retorna um valor se houver um atribuido,
            //de outra forma será lançada uma execeção System.InvalidOperationException;
            //O valor padrão para uma variável do tipo anulável define HasValue como false e Value como Indefinido;

            //int? valor = 90;
            ////verificar se o numero é nulo
            //if (valor != null)
            //{
            //    Console.WriteLine("{0}", valor);
            //    Console.ReadKey();
            //}

            //conversão implicita de tipo não nulo e anulavel
            //int? valor = 100; //implicitamente

            //int valint = (int)valor; //explicitamente

            //DateTime? dataNascimento = null;
            //if (dataNascimento.HasValue)
            //{
            //    Console.WriteLine("Data de nascimento 'foi definida'");
            //} else
            //{
            //    Console.WriteLine("Data de nascimento é null");
            //}
            //Console.ReadKey();

            //DateTime? dataNascimento = null;
            DateTime? dataNascimento = DateTime.Now;
            if (dataNascimento.HasValue)
            {
                Console.WriteLine("Data de nascimento 'foi definida'");
            } else
            {
                Console.WriteLine("Data de nascimento é null");
            }

            try
            {
                Console.WriteLine(dataNascimento.Value);
            } catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
