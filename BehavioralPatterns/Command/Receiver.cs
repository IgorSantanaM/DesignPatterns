using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Receiver
    {
        public void Action(string message)
        {
            Console.WriteLine($"Receiver Invoked: {message}");
        }

        public void UndoAction(string message)
        {
            Console.WriteLine($"Receiver undoing: {message}");
        }
    }
}
