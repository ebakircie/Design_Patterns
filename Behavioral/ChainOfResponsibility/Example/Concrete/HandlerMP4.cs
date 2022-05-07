using ChainOfResponsibility.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example.Concrete
{
    public class HandlerMP4:PlayerHandler
    {
        public override void Player(string fileName)
        {
            if (fileName.EndsWith(".mp4"))
            {
                int index = fileName.LastIndexOf(".");
                string subs = fileName.Substring(index);
                string format = subs.Trim('.');

                Console.WriteLine(format + " type media is playing.");
            }
            else
            {
                if (_nextHandler !=null)
                {
                    _nextHandler.Player(fileName);
                }
            }
        }
    }
}
