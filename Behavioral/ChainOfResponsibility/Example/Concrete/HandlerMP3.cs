using ChainOfResponsibility.Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example.Concrete
{
    public class HandlerMP3:PlayerHandler
    {
        public override void Player(string fileName)
        {
            if (fileName.EndsWith(".mp3"))
            {
                string format = fileName.Split('.').Last();

                Console.WriteLine(format + " type media is playing.");
            }
            else
            {
                if (_nextHandler != null)
                {
                    _nextHandler.Player(fileName);
                }
            }
        }
    }
}
