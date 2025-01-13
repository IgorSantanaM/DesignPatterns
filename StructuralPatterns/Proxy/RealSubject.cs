namespace Proxy
{
    public class RealSubject : Subject
    {

        public RealSubject()
        {
            Console.WriteLine("Initiating real") ;
        }
        public void Operation()
        {
            Console.WriteLine("Peforming operation on real subject");
        }

    }
}
