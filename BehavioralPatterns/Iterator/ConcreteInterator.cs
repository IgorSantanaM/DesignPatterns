using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ConcreteInterator<T>(ConcreteAggregate<T> concreteAggregate) : Iterator<T>
    {
        private readonly ConcreteAggregate<T> _concreteAggregate = concreteAggregate;
        private int _currentIndex = -1;
        public bool HasNext()
        {
            return _currentIndex < _concreteAggregate.Count - 1;
        }

        public T Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException();
            }

            _currentIndex++;
            return _concreteAggregate.GetItemAt(_currentIndex);
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
