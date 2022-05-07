using ChainOfResponsibility.Example.Abstract;
using ChainOfResponsibility.Example.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerHandler aviPlayer = new HandlerAvi();
            PlayerHandler mp3Player = new HandlerMP3();
            PlayerHandler mp4Player = new HandlerMP4();

            mp3Player.NextHandler = mp4Player;
            mp4Player.NextHandler = aviPlayer;

            mp3Player.Player("video.mkv");
            mp3Player.Player("video.mp3");
            mp3Player.Player("video.avi");
            mp3Player.Player("video.flv");
            mp3Player.Player("video.mp4");

            Console.ReadKey();

        }
    }
}
