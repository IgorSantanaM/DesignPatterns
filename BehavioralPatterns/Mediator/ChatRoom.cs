using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatRoom() : IChatRoomMediator
    {
        private List<User> _users = [];
        public void AddUser(User user)
        {
            _users.Add(user);
            user.SetMediator(this);
        }

        public void Notify(User sender, string message)
        {
            foreach (User user in _users)
            {
                if(user != sender)
                {
                    user.Receive(message, sender.Name);
                }
            }
        }
    }
}
