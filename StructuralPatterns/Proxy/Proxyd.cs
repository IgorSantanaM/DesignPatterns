namespace Proxy
{
    public class Proxyd : Subject
    {
        private RealSubject? _realSubject = null;
        public Proxyd()
        {   
            Console.WriteLine("Initiating Proxy");
        }
        public void Operation()
        {
            Console.WriteLine("Peforming operation on Proxy");

            if(_realSubject is null)
            {
                Console.WriteLine("Real subject is null, creating...");

                _realSubject = new RealSubject();
            }
            Console.WriteLine("Logging before the operation");
            _realSubject.Operation();
            Console.WriteLine("Logging after the operation");
        }

    }
}
