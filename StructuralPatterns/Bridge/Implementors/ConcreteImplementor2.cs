using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementors
{
    public class ConcreteImplementor2 : Implementor
    {
        public void Print()
        {
            Console.WriteLine("Hello from implementor 2");
        }
    }
}
