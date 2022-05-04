using System;
using System.Collections.Generic;

namespace AbstractFactoryMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            AbstractFactory factory1=new ConcreteFactorySamsung();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactoryApple();
            Client client2 = new Client(factory2);
            client2.Run();
            Console.ReadKey();
        }
    }
}