using System;

namespace Estruturas05
{
    class Program
    {
        //Construtores são métodos especiais, usados para instanciar uma classe.Um construtor nunca pode retornar nada, 
        //e é por isso que você não precisa definir um tipo de retorno para ele.Um método normal é definido assim:
        //public string Describe()
        //Um construtor pode ser definido assim:
        //public Car()


        public struct Pessoa
        {
            public string Nome;
            public int Idade;

            //construtor => Pessoa p = new Pessoa (1.98, 90, 26.45)

            public Pessoa(string _nome, int _idade)
            {
                Nome = _nome;
                Idade = _idade;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Instanciando uma struct com construtor");
            Pessoa Lucas = new Pessoa("Lucas da Silva Lima", 24);

            Console.WriteLine("Exibindo os valores atribuidos no construtor");

            Console.WriteLine("Nome: {0}", Lucas.Nome);
            Console.WriteLine("Idade: {0}", Lucas.Idade);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
