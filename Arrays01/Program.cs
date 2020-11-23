using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 12 - Arrays
/// Exemplo - 01
/// </summary>
/// 
namespace Arrays01
{
    class Program
    {
        //Arrays são basicamente variaveis onde pode-se armazenar mais de um elemento do mesmo tipo.
        //Um array é um conjunto de dados uniformes
        static void Main(string[] args)
        {
            //declaração de um array
            int[] valor1;
            valor1 = new int[5];
            valor1[0] = 1;
            valor1[1] = 2;
            valor1[2] = 3;
            valor1[3] = 4;
            valor1[4] = 5;
            //
            string[] nomes = new string[2];
            nomes[0] = "Lucas";
            nomes[1] = "Daniele";
            //
            int[] n2 = { 10, 20, 30, 40, 50 };
            int[] n3 = new int[]{ 10, 20, 30, 40, 50 };
            int[] n4 = new int[5]{ 10, 20, 30, 40, 50 };
            int[] n5 = new int[5];
            n5[0] = 10;
            //
            double[]d1 = new double[5];
            float[]f1 = new float[5];

            //
            int[,] numeros = new int[3, 2]
            {
                {1, 2},
                {3, 4},
                {5, 6},
            };

            //array de 3 dimensões: Colunas, Linhas, Dimensões
            int[,,] arr3d = new int[3, 5, 4];
               arr3d[0,0,0] = 1;
               arr3d[0,1,0] = 2;
               arr3d[0,2,0] = 3;
               arr3d[0,3,0] = 4;
               arr3d[0,4,0] = 5;
               arr3d[1,1,1] = 2;
               arr3d[2,2,2] = 3;
               arr3d[2,2,3] = 4;

        }
    }
}
