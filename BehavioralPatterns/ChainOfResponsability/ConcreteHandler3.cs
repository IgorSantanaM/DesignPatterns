using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class ConcreteHandler3 : Handler
    {
        public override void Handle(string request)
        {
            if (request == "3")
            {
                Console.WriteLine("ConcreteHandler 3 handled request 3");
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
