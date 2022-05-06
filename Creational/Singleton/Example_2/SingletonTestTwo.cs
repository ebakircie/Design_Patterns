using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example_2
{
    public class SingletonTestTwo
    {
        private SingletonTestTwo()
        {

        }
        private static SingletonTestTwo _singletonTestTwoObject;

        public static SingletonTestTwo SingletonTestTwoObject
        {
            get
            {
                if (_singletonTestTwoObject == null)
                {
                    _singletonTestTwoObject = new SingletonTestTwo();
                }
                return _singletonTestTwoObject;
            }
            private set { }
        }

        public int Sum (int num1, int num2)
        {
            return num1 + num2;
        }
            


    }
}
