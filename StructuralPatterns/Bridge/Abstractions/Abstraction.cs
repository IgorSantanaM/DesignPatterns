using Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstractions
{
    public abstract class Abstraction(Implementor implementor)
    {
        protected Implementor Implementor { get; init; } = implementor;

        public abstract void Foo();
    }
}
