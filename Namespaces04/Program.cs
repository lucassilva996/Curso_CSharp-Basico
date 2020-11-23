using System;
using A.B.C;
/// <summary>
/// Curso C# - Módulo Básico
/// Aula 13 - Namespaces
/// Exemplo - 04 
/// </summary>
/// 
namespace E
{
    using D;

    class Program
    {

        //Este exemplo tem namespaces com os identificadores A, B, C, D, E e F. 
        //Os Namespaces B e C estão aninhados dentro dos Namespaces namespace A. 
        //Os namespaces D, E e F estão todos no nível superior da unidade de compilação. 
        //Na classe Program, observe como o ponto de entrada Main usa os tipos CClass, DClass e Fclass. 
        //Como as diretivas using A.B.C e using D estão presentes no namespace E , o método Main 
        //pode usar esses tipos diretamente. 
        //Com FClass, o namespace deve ser especificado explicitamente porque F não está incluído dentro
        //de E com uma directiva using.
        static void Main(string[] args)
        {
            // Pode acessar o tipo CClass diretamente a partir de A.B.C.
            CClass var1 = new CClass();

            // Pode acessar o tipo DClass a partir de D
            DClass var2 = new DClass();

            // Precisa especificar explicitamente o namespace F
            F.FClass var3 = new F.FClass();

            // saida
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.ReadKey();
        }
    }
}

namespace A
{
    namespace B
    {
        namespace C
        {
            public class CClass
            {
            }
        }
    }
}

namespace D
{
    public class DClass
    {
    }
}

namespace F
{
    public class FClass
    {
    }
}
