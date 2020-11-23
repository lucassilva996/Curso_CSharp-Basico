using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 08 - Conversão de Tipos
/// Exemplo 4
/// </summary>


//conversão implicita quando não há perca de precisão, geralmente ocorre a conversão de uma variavel menor para uma maior.
//conversão explicita quando há perca de valor ou arredondamento
namespace ConversaoTipos04
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();
            //conversão de um quadrado - conversão implicita
            //esse tipo de conversão é possível pois a classe Quadrado deriva da classe Retangulo.
            Retangulo r = q;

            //conversão explícita - cast
            Quadrado q1 = (Quadrado)r;
        }

        //classe base
        class Retangulo
        {
            public int x = 10, y = 10;
            public int GetArea()
            {
                return x* y;
            }
        }
        //classe derivada
        //A Classe quadrado é um tipo de especialização da classe base
        //Assim um quadrado é do tipo retangulo
        class Quadrado : Retangulo
        {
            public int getPerimetro()
            {
                return (2 * x + 2 * y);
            }
        }

    }
}
