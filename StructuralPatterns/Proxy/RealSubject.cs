using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealSubject : Subject
    {

        public RealSubject()
        {
            Console.WriteLine("Initiating real subject");
        }
        public void Operation()
        {
            Console.WriteLine("Peforming operation on real subject");
        }

    }
}
