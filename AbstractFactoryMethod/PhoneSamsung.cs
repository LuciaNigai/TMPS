using System;
namespace AbstractFactoryMethod
{
    class PhoneSamsung :Phone
    {
        public override void call()
        {
            Console.WriteLine("Calling");
        }

        public override void sendMessage()
        {
            Console.WriteLine("Sending message");
        }
    }
}