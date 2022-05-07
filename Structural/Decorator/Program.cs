using Decorator.Example.Abstract;
using Decorator.Example.Clients;
using Decorator.Example.Concrete;
using Decorator.Example.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();

            Client.Display("Stand Alone version: ", component);
            Client.Display("Decorator A:", new DecoratorA(component));
            Client.Display("Decorator B:", new DecoratorB(component));
            Client.Display("Multiply Decorator:", new DecoratorA(new DecoratorB(component)));

            Console.ReadKey();
        }
    }
}
