using Mediator.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Example.Mediator.Abstract
{
    public interface IChatMediator
    {
        void AddUser(IUser user);

        void SendMessage(string message, IUser senderUser);
    }
}
