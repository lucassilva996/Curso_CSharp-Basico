using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 12 - Arrays
/// Exemplo - 03 - Percorrer um array
/// </summary>
/// 

namespace Arrays03
{
    class Program
    {
        static void Main(string[] args)
        {
            //percorrendo um array tridimencional 3 linhas
            int[,,] arr3d = new int[3, 5, 4];
            arr3d[0, 0, 0] = 1;
            arr3d[0, 1, 0] = 2;
            arr3d[0, 2, 0] = 3;
            arr3d[0, 3, 0] = 4;
            arr3d[0, 4, 0] = 5;
            arr3d[1, 1, 1] = 2;
            arr3d[2, 2, 2] = 3;
            arr3d[2, 2, 3] = 4;
            
            //percorre cada dimensão do array
            for(int i=0; i < arr3d.GetLength(2); i++)
            {
                for (int y = 0; y < arr3d.GetLength(1); y++)
                {
                    for (int x = 0; x < arr3d.GetLength(0); x++)
                    {
                        Console.WriteLine(arr3d[x, y, i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
