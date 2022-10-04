using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class Enumt12
    {
        enum CSharp_concepts
        {
            Basics,
            Methods = 10,
            ControlStmts,
            OOPS = 20,
            Delegates = 400,
            Structures = -3,
            Files,
            Generics
        }
        public static void Main()
        {
            Console.WriteLine(CSharp_concepts.Basics);
            int methods = (int)CSharp_concepts.Methods;
            Console.WriteLine(methods);
            var del = (CSharp_concepts)400;
            Console.WriteLine(del);
            int structures = (int)CSharp_concepts.Structures;
            Console.WriteLine(structures);

        }
    }
}