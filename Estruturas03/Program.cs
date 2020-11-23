using System;

namespace Estruturas03
{
    class Program
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
            //Pessoa Lucas = new Pessoa();
            Pessoa Lucas;
            Console.WriteLine("Informe a sua altura (em metros)?");
            Lucas.Altura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o seu peso (em kg)?");
            Lucas.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A sua altura é {0} m e seu peso é {1} Kg", Lucas.Altura, Lucas.Peso);

            Lucas.IMC = calcularIMC(Lucas.Peso, Lucas.Altura);

            Console.WriteLine("O seu imc é {0}", Lucas.IMC);
            exibeResultado(Lucas.IMC);
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
