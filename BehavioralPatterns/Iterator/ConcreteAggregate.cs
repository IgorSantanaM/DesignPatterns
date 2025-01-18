using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ConcreteAggregate<T> : Aggregate<T>
    {
        private readonly List<T> _items = [];

        public int Count => _items.Count;

        public T GetItemAt(int index)
        {
            return _items[index]; 
        }    
        public void Add(T value)
        {
            _items.Add(value);
        }

        public Iterator<T> CreateIterator()
        {
            return new ConcreteInterator<T>(this);
        }
    }
}
