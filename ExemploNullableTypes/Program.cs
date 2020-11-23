/// <summary>
/// Curso C# - Módulo Básico
/// Aula 03 - Nullable Types
/// Exemplo 1
/// </summary>
using System;

namespace ExemploNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable types são usados para aceitar um valor null em variávéis tipadas
            //, ou seja, o valor padrão de um nullable não será 0
            //abaixo, vemos que a declaração está incorreta
            //string nome = null;
            //int valor = null;

            //declaração correta
            string nome = null;
            int? valor = null;
            Nullable<int> valor2 = null;

            double? d = 3.14;
            bool? flag = null;
            char? letra = 'A';
            int?[] array = new int?[10];
        }
    }
}
