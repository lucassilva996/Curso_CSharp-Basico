using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 14 - Métodos e Funções
/// Exemplo - 01 
/// </summary>
/// 


//procedimentos - estruturas que agrupam conjunto de comandos
//q são executados quando o procedimento é chamada. Não é obrigado retorna valor(void).

//funções - são semelhantes a procedimentos, exceto que uma função sempre retorna valor(tipo)

//Metodos - Identificados por um nome e podem ter parametros e retornar ou não um valor
//exemplos:(Assinatura do método)
//void NomeMetodo() - não retorna dados(void) nem recebe parâmetros.

//int NomeMetodo (int par1, int par2) - Retorna dados do tipo int e recebe parâmetros do tipo int

//void NomeMetodo (string nome) - Não retorna dados e recebe um parâmetros do tipo string


namespace Metodos01
{
    class Program
    {
        //não retorna Dados e nem recebe parâmetros
        void Teste()
        {}

        //método do tipo int, retorna dados e recebe parametros
        int Calculo(int Valor1, int Valor2)
        {
            return Valor1 + Valor2;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
