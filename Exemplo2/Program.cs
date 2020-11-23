/// <summary>
/// Curso C# - Módulo Básico
/// Aula 02 - Variáveis e Tipos (1º Aula Prática)
/// Exemplo 2 - Calcula a área do Circulo A = PI * Raio * Raio
/// </summary>

using System;

namespace Exemplo2
{
    class AreaCirculo
    {
        static void Main(string[] args)
        {
            double raioDoCirculo, areaDoCirculo;
            const double VALORDOPI = 3.1416;
            raioDoCirculo = 10.0;
            areaDoCirculo = (raioDoCirculo * raioDoCirculo * VALORDOPI);
            Console.WriteLine("A Área do círculo de Raio 10 é: " + areaDoCirculo);
            Console.ReadKey();
        }
    }
}
