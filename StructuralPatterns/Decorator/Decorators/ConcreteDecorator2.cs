using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class ConcreteDecorator2(Component component) : Decorator(component)
    {
        public override void Operation()
        {
            Console.WriteLine("-----------------------concretedecorato2");
            _component.Operation();
            Console.WriteLine("-----------------------concretedecorato2");
        }
    }
}
