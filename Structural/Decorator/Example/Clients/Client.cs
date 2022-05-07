using Decorator.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example.Clients
{
    public class Client
    {
        public static void Display (string s, IComponent component)
        {
            Console.WriteLine(s + component.Operation());
        }
    }
}
