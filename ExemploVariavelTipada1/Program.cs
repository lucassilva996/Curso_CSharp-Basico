/// <summary>
/// Curso C# - Módulo Básico
/// Aula 04 - Variáveis Implicitas
/// Exemplo 1
/// </summary>
using System.Linq;
using System.Data;
using System;
using System.Collections.Generic;

namespace ExemploVariavelTipada1
{
    /// <summary>
    /// Variáveis tipadas implicitamentes são as variaveis que são definidas pela palavra VAR
    /// A palavra-chave VAR instrui o compilador a deduzir o tipo da variável a partir da expressão no lado direito da instrução
    /// O tipo inferido pode ser um tipo interno, um tipo anonimo, um tipo usuário ou um tipo definido na biblioteca de classes do .NET
    /// Exemplo: int x = 0; ou var x = 0; são a mesma coisa
    /// Var não significa variant e não indica que a variável é fracamente tipada
    /// VAR = utilizar quando tenho nome muito grande de classe ou quando preciso tratar com um cenário onde pode criar uma inicialização implicita, economizando tempo e sem usar tipos.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //declaração explicita
            int valor = 100;

            //declaração implicita
            //var numero = 200;

            //var i = 5;

            //var nome = "Lucas";

            //var vetor = new[] { 0, 1, 2 };

            //var aluno = new { Nome = "Lucas" };

            //var lista = new List<int>();

            //NorthwindEntities db = new NorthwindEntities();
            //var consulta = from c in db.Customers
            //               where c.City == "London"
            //               select c;

            //string[] nomes = { "Lucas", "Daniele" };
            //var consulta = from nome in nomes
            //               where nome[0] == "m"
            //               select nome;

            //foreach(string n in consulta)
            //{
            //    Console.WriteLine(n);
            //}

            //classeComNomeMuitoGrandeDeDigitar<string> obj1 = new classeComNomeMuitoGrandeDeDigitar<string>();
            ////o var é recomendado em classes com nomes muito grandes
            //var obj2 = new classeComNomeMuitoGrandeDeDigitar<string>();

            //[SEM VAR]array chamado vetor com dois valores e tratar os elementos cujo tamanho seja maior que 5
            //string[] Vetor = { "Lucas", "Daniele" };
            //IEnumerable<Lucas> obj = from x in Vetor
            //                         where x.Length > 5
            //                         select new Lucas { Tamanho = x.Length, valor = x };

            ////[UTILIZANDO VAR]array chamado vetor com dois valores e tratar os elementos cujo tamanho seja maior que 5
            //string[] Vetor2 = { "Lucas", "Daniele" };
            //var obj1 = from x in Vetor
            //                         where x.Length > 5
            //                         select new Lucas { Tamanho = x.Length, valor = x };

            //não fazer
            //criar variável sem inicializar
            //var nome;

            //criar variavel com valor null
            //var nome = null;

            //não usar variaveis declaradas usando expressão de inicialização
            //var i = (i = 20);

            //multiplas variaveis de tipo implicito não podem ser iniciadas na mesma instrução
            //var a = 5, b = 9, c = 90;
        
        
        }
    }
    //class classeComNomeMuitoGrandeDeDigitar<T>
    //{ }

    //class Lucas
    //{
    //    public int Tamanho;
    //    public string valor;
    //}
}
