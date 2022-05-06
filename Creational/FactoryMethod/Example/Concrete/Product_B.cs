using FactoryMethod.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example.Concrete
{
    public class Product_B : IProduct
    {
        public string ShipFrom()
        {
            return "Ireland";
        }
    }
}
