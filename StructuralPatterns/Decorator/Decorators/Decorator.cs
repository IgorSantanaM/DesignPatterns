using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public abstract class Decorator(Component component) : Component
    {

        public Component _component = component;
        public virtual void Operation()
        {
            _component.Operation();
        }
    }
}
