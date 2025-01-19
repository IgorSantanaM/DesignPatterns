using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementors
{
    public class ConcreteImplementor1 : Implementor
    {
        public void Print()
        {
            Console.WriteLine("Hello from implementor 1");
        }
    }
}
