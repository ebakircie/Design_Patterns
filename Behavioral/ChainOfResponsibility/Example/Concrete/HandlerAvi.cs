using ChainOfResponsibility.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example.Concrete
{
    public class HandlerAvi : PlayerHandler
    {
        public override void Player(string fileName)
        {
            if (fileName.EndsWith(".avi"))
            {
                string format = fileName.Substring(fileName.LastIndexOf(".") + 1);
                
                Console.WriteLine(format + " type media is playing.");
            }
            else
            {
                Console.WriteLine("Invalid media format!");
            }
        }
    }
}
