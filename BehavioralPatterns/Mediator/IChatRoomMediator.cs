using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IChatRoomMediator
    {
        void Notify(User sender, string message);
        void AddUser(User user);
    }
}
