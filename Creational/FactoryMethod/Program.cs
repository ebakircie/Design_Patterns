using FactoryMethod.Example;
using FactoryMethod.Example.Abstract;
using System;


namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCreator productCreator = new ProductCreator();

            IProduct product;
            for (int month = 1; month <= 12; month++)
            {
                product = productCreator.FactoryMethod(month);
                Console.WriteLine("Products shipped from "+ product.ShipFrom());
            }

            Console.ReadKey();
        }
    }
}
