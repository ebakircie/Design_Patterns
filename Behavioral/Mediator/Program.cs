using Mediator.Example.Abstract;
using Mediator.Example.Concrete;
using Mediator.Example.Mediator.Abstract;
using Mediator.Example.Mediator.Concrete;
using System;
namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser pazuzu = new BasicUser(chatMediator, "pazuzu");
            IUser ersin = new GoldUser(chatMediator, "ersin");
            IUser paz = new BasicUser(chatMediator, "paz");

            chatMediator.AddUser(pazuzu);
            chatMediator.AddUser(ersin);
            chatMediator.AddUser(paz);

            pazuzu.SendMessage("Test message sent by pazuzu ");


            Console.ReadKey();
        }
    }
}
