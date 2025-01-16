using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteClass2 : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive Operation 1 called");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive Operation 2 called");
        }

        public override void Hook()
        {
            Console.WriteLine("Hook called at the concrete class.");
        }
    }
}
