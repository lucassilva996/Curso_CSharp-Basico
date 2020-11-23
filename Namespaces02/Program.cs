using System;

/// <summary>
/// Curso C# - Módulo Básico
/// Aula 13 - Namespaces
/// Exemplo - 02
/// </summary>
/// 

namespace Namespaces02
{
    namespace Brasil
    {
        class Program
        {
            static void Main(string[] args)
            {
                Namespaces02.Lucas.TesteNamespaces.Exibir("Hello World");
                Namespaces02.Brasil.Program.Exibir("Ola Mundo");
                Console.ReadKey();
            }
            static public void Exibir(string texto)
            {
                Console.WriteLine(texto);
            }
        }

        
    }
}
