using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Example.Abstract
{
    public interface IUser
    {
        void SendMessage(string message);
        void RecevieMessage(string message);
    }
}
