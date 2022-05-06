using Singleton.Example_1;
using Singleton.Example_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var singleton = SingletonTest.CreateObject();

            Console.WriteLine(singleton.CreateLog());

            singleton.Id = 10;



            var sum = SingletonTestTwo.SingletonTestTwoObject.Sum(10, 20);

            var anotherSum = SingletonTestTwo.SingletonTestTwoObject.Sum(69, 96);

            Console.WriteLine("Outcome: " + sum);
            Console.WriteLine("Outcome: " + anotherSum);

          Console.ReadKey();
        }
    }
}
