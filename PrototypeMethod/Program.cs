using System;
namespace PrototypeMethod
{
    class MainApp
    {
        static void Main ()
        {
            Console.Clear();
            IGadgets gadget = new Smartphone("red", 4.5);
            IGadgets clonedGadget = gadget.Clone();
            gadget.GetInfo();
            clonedGadget.GetInfo();

            gadget = new SmartWatch(1.8,"sensor",5);
            clonedGadget = gadget.Clone();
            gadget.GetInfo();
            clonedGadget.GetInfo();
        }
    }
}