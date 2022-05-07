using Decorator.Example.Abstract;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example.Concrete
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return " E-mail sent";
        }
    }
}
