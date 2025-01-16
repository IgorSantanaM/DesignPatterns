using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class AdminUser(string name) : User(name)
    {
        public override void Receive(string message, string sender)
        {
            Console.WriteLine($"Admin: {Name}, receives from {sender}: {message}");

        }

        public override void Send(string message)
        {
            Console.WriteLine($"Admin: {Name}, announces: {message}");
            _mediator.Notify(this, $"ADMIN MESSAGE: {message}");
        }
        public void BroadcastAlert(string alert)
        {
            Console.WriteLine($"Admin: {Name}, broadcasts alert: {alert}");
            _mediator.Notify(this, $"ADMIN BROADCAST: {alert}");
        }


    }
}
