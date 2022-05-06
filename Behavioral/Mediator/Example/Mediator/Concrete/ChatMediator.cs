using Mediator.Example.Abstract;
using Mediator.Example.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Example.Mediator.Concrete
{
    public class ChatMediator : IChatMediator
    {
        private IList<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser senderUser)
        {
            foreach (IUser user in users)
            {
                if (user != senderUser)
                {
                    user.RecevieMessage(message);
                }
            }
        }
    }
}
