using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private string _state = string.Empty;

        public void SetState(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }
        public class Memento
        {
            private readonly string _state;

            internal Memento(string state)
            {
                _state = state;
            }

            internal string GetState()
            {
                return _state;
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void Restore(Memento memento)
        {
            _state = memento.GetState();
        }
    }
}
