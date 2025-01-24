using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class ConcreteHandler1 : Handler
    {
        public override void Handle(string request)
        {   
            if(request == "1") 
            {
                Console.WriteLine("ConcreteHandler 1 handled request 1");
                return;
            }

            if(_successor is null)
            {
                return;
            }

            _successor.Handle(request);
        }
    }
}
