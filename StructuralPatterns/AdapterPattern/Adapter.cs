using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter(Adaptee adaptee) : ITarget
    {
        public void Request()
        {
            adaptee.EspecificRequest();
        }
    }
}
