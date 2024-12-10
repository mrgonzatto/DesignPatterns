using Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstractions
{
    public class RefinedAbstraction2(Implementor implementor) : Abstraction(implementor)
    {
        public override void Foo()
        {
            Console.WriteLine("-------");
            Implementor.Print();
            Console.WriteLine("-------");
        }
    }
}
