using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example_1
{
    public class SingletonTest
    {
        private SingletonTest()
        {

        }

        private static SingletonTest _singleton;
        public static SingletonTest CreateObject()
        {
            
            if (_singleton == null)
                _singleton = new SingletonTest();
            return _singleton;
        }
        
        public string CreateLog()
        {
            return "System log created!";
        }

        public int Id { get; set; }
    }
}
