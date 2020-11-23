using System;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 10 - Enumeradores
/// Exemplo 01
/// </summary>


namespace Enumeradores01
{
    //Enumaração é um recurso que fornece uma forma convenientede 
    //tratar um conjunto relacionado de constantes
    //e de associar os valores destas constantes com os nomes atribuídos a elas.
    class Program
    {
        private enum EstadoCivil { Casado, Solteiro, Viuvo, Divorciado}
        enum DiaSemana { Seg, Ter, Qua, Qui, Sex, Sab, Dom}
        
        enum DiaMes : byte { Jan, Fev, Mar, Abr, Mai, Jun, Jul, Ago, Set, Out, Nov, Dez}

        enum Estado
        {
            Desligado = 0,
            Ligado = 5,
            Repouso = 10, 
            Processando = Ligado + 10
        }
        static void Main(string[] args)
        {
            DiaSemana dia = DiaSemana.Qui;
            //conversão explicita para pegar o valor int do enum.
            int x = (int)DiaSemana.Qui;
            Console.WriteLine("Hoje é : " + dia);
            Console.WriteLine("Hoje é o dia: " + x);
            string s = Enum.GetName(typeof(DiaSemana), 3);
            Console.WriteLine("Dia da Semana 4 é " + s);


            Console.WriteLine("Os valores da Enumeração (GetValues) Dia Semana são:\n ");
            foreach (int i in Enum.GetValues(typeof(DiaSemana)))
                Console.WriteLine(i);

             Console.WriteLine("Os nomes dos dias no enum (GetNames) são:\n ");
             foreach (string str in Enum.GetNames(typeof(DiaSemana)))
                Console.WriteLine(str);

            Console.ReadKey();

        }

        private static void Estado_Civil(EstadoCivil s)
        {
            switch (s)
            {
                case EstadoCivil.Solteiro:
                    Console.WriteLine("Solteiro\n");
                    break;
                case EstadoCivil.Casado:
                    Console.WriteLine("Casado\n");
                    break;
                case EstadoCivil.Viuvo:
                    Console.WriteLine("Viuvo\n");
                    break;
                case EstadoCivil.Divorciado:
                    Console.WriteLine("Divorciado\n");
                    break;
                default:
                    throw new Exception("O valor informado está fora do escopo da Enumeration");
                
            }
        }
    }
}
