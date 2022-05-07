using Decorator.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example.Decorators
{
    public class DecoratorA : IComponent
    {
        IComponent _component;
        public DecoratorA(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            return _component.Operation() + " Location information shared.";
        }
    }
}
