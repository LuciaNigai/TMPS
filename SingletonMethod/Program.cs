using System;

namespace SingletonMethod
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Phone p = Phone.getInstance("Red");
        // Phone pp = new Phone("Purple");
        Console.WriteLine(p.Color);
        Phone c = Phone.getInstance("Yelow");
        Console.WriteLine(c.Color);
        Console.WriteLine(p.GetHashCode());
        Console.WriteLine(c.GetHashCode());
        if (p==c)
        {
            Console.WriteLine("Singletone is working");
        }
    }
} 
}