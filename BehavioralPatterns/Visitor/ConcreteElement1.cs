using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ConcreteElement1 : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public string Operation1()
        {
            return "Concrete Element 1";
        }
    }
}
