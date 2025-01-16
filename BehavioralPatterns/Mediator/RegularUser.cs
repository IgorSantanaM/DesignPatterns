namespace Mediator
{
    public class RegularUser(string name) : User(name)
    {
        public override void Receive(string message, string sender)
        {
            Console.WriteLine($"{Name}, receives from {sender}: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.Notify(this, message);
        }
    }
}
