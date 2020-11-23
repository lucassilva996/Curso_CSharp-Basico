using System;

namespace Estruturas04
{
    public class Program
    {

        //criar a estrutura
        public struct Pessoa
        {
            public double Altura;
            public double Peso;
            public double IMC;
        }

        static void Main(string[] args)
        {
            Pessoa[] dadosPessoa = new Pessoa[3];
            int i = 0;
            do
            {
                //obter os dados do usuário
                Console.WriteLine("Digite a sua altura em metros? ");
                dadosPessoa[i].Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o seu peso em kg? ");
                dadosPessoa[i].Peso = Convert.ToDouble(Console.ReadLine());
                //calcular o IMC
                dadosPessoa[i].IMC = calcularIMC(dadosPessoa[i].Peso, dadosPessoa[i].Altura);

                //exibir o resultado
                Console.WriteLine("A  sua altura é {0} mts e seu peso é {1} Kg ", dadosPessoa[i].Altura, dadosPessoa[i].Peso);
                Console.WriteLine("O seu IMC é {0}: ", dadosPessoa[i].IMC);
                exibeResultado(dadosPessoa[i].IMC);
                i++;
            } 
            while (i < dadosPessoa.Length);

            Console.WriteLine("=========================");
            //percore o vetore imprime os dados na tela
            for (int x = 0; x < dadosPessoa.Length; x++)
            {
                Console.WriteLine("Altura: {0}\tPeso: {1}\tIMC: {2}\n", dadosPessoa[x].Altura, dadosPessoa[x].Peso, dadosPessoa[x].IMC);
            }
            Console.ReadKey();
        }
        public static void exibeResultado(double imc)
        {
            if (imc <= 18.5)
                Console.WriteLine("Magreza");
            if (imc >= 18.5 && imc <= 24.9)
                Console.WriteLine("Normal");
            if (imc >= 25.0 && imc <= 29.9)
                Console.WriteLine("Sobrepeso");
            if (imc >= 30.0 && imc <= 39.9)
                Console.WriteLine("Obesidade");
            if (imc >= 40.0)
                Console.WriteLine("Obesidade Grave");
        }

        public static double calcularIMC(double peso, double altura)
        {
            return peso / (Math.Pow(altura, 2));
        }
    }
}
