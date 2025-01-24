using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler? _successor = null;

        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }

        public abstract void Handle(string request);
    }
}
