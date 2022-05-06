using Mediator.Example.Abstract;
using Mediator.Example.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Example.Concrete
{
    public class GoldUser : IUser
    {
        string _username;

        IChatMediator _chatMediator;
        public GoldUser(IChatMediator chatMediator, string username)
        {
            _chatMediator = chatMediator;
            _username = username;
        }

        public void RecevieMessage(string message)
        {
            Console.WriteLine("User Level: Gold" + "\n" + "Username: " + _username + "\n" + "Message: " + message);
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
