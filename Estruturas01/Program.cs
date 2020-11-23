using System;

namespace Estruturas01
{
    class Program
    {
        static void Main(string[] args)
        {
            //calcular IMC - IMC = Peso / Altura * Altura
            //definição de variaveis
            double peso, altura, imc;
            //obter os valores informados
            Console.WriteLine("Digite a sua altura em metros? ");
            altura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o seu peso em kg? ");
            peso = Convert.ToDouble(Console.ReadLine());
            //calcular o IMC
            imc = peso / (Math.Pow(altura,2));

            //exibir o resultado
            Console.WriteLine("A  sua altura é {0} mts e seu peso é {1} Kg ", altura, peso);
            Console.WriteLine("O seu IMC é: ", imc);

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
    }
}
