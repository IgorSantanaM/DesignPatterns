using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class ConcreteFlyweight(string instrisicState) : Flyweight
    {
        public readonly string _intrisicState = instrisicState;
        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"Concrete flyweight: Instrisic State: {_intrisicState}, Extrinsic State: {extrinsicState}");
        }
    }
}
