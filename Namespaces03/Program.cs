using System;
using mensagem = Brasil.Brasilia.LucasSilva.Teste;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 13 - Namespaces
/// Exemplo - 03
/// </summary>
/// 
namespace Namespaces03
{
    namespace Brasil
    {
        class Program
        {
            static void Main(string[] args)
            {
                mensagem.Exibir("Acessando Namespaces com alias");
                Console.ReadKey();
            }
            
        }
    }
}
//---------- fim Namespace_3
namespace Brasil.Brasilia
{
    namespace LucasSilva
    {
        public class Teste
        {
            static public void Exibir(string texto)
            {
                Console.WriteLine(texto);
            }
        }
    }
}