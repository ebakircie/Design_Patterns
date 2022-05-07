using Decorator.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example.Decorators
{
    public class DecoratorB:IComponent
    {
        private IComponent _component;
        public DecoratorB(IComponent component)
        {
            _component = component;
        }

        public string Operation()
        {
            return _component.Operation() + " Payment information shared.";
        }
    }
}
