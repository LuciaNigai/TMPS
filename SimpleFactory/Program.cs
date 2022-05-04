using System;
using System.Collections.Generic;
namespace SimpleFactory
{
    public static class Program
    {
        public static void Main()
        {
            Console.Clear();
            Creator creator = new ConcreteCreatorSamsung();
            ProductPhone product = creator.FactoryMethod();
            Console.WriteLine(product.Procesor());
            Creator creator2 = new ConcreteCreatorApple();
            ProductPhone product2 = creator2.FactoryMethod();
            Console.WriteLine(product2.Procesor());

        }
    }
}