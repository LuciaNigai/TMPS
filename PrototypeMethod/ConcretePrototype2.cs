namespace PrototypeMethod
{
    class SmartWatch : IGadgets
    {
        double diagonal;
        string displayType;
        int bateryLife;

        public SmartWatch (double d, string dis, int b)
        {
            diagonal=d;
            displayType=dis;
            bateryLife=b;
        }
        
        public IGadgets Clone()
        {
            return new SmartWatch(this.diagonal, this.displayType, this.bateryLife);
        }

        public void GetInfo()
        {
            Console.WriteLine("Smart Watch with diagonal {0} display type {1} and batery life {2} hours",diagonal, displayType, bateryLife);
        }
    }
}