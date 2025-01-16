using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        public virtual void Hook()
        {
            Console.WriteLine("Hook invoked");
        }

        public void TemplateMethod()
        {
            Console.WriteLine("Before Operation 1");
            PrimitiveOperation1();
            Console.WriteLine("Before Operation 2");
            PrimitiveOperation2();
            Console.WriteLine("Before Hook");
            Hook();
        }
    }
}
