using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class ConcreteHandler2 : Handler
    {
        public override void Handle(string request)
        {
            if (request == "2")
            {
                Console.WriteLine("ConcreteHandler 2 handled request 2");
                return;
            }

            if (_successor is null)
            {
                return;
            }

            _successor.Handle(request);
        }
    }
}
