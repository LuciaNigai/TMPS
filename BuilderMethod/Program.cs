using System;
using System.Collections.Generic;

namespace BuilderMethod
{
    //Client
        public static class Program
        {
            public static void Main()
            {
                Console.Clear();
                BuilderPhone builder = new ConcreteBuilderA();
                Director director = new Director(builder);
                director.Construct();
                ProductPhone product =  builder.GetResult();

                BuilderPhone builder2 = new ConcreteBuilderB();
                Director director2 = new Director(builder2);
                director2.Construct();
                ProductPhone product2 =  builder2.GetResult();
            }
        }
}