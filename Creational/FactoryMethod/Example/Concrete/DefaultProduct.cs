using FactoryMethod.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example.Concrete
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return "Shipping isn't available at the moment!";
        }
    }
}
