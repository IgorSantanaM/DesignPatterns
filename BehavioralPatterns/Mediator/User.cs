using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class User(string name)
    {
        public string Name { get; protected set; }
        protected IChatRoomMediator _mediator = null!;

        public void SetMediator(IChatRoomMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message, string sender);
    }
}
