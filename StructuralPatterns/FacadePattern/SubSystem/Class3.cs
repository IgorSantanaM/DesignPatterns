using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystem
{
    public class Class3(Class2 class2)
    {
        public void Operation4(Class1 class1)
        {
            class2.Operation3();
            class1.Operation2();   
        }
    }
}
