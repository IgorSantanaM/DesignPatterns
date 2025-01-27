using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ConcreteElement2 : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public string Operation2()
        {
            return "Concrete Element 2";
        }
    }
}
