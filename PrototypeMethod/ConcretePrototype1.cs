namespace PrototypeMethod
{
    class Smartphone : IGadgets
    {
        string color;
        double diagonal;
        
        public Smartphone (string c, double d)
        {
            color=c;
            diagonal=d;
        }

        public IGadgets Clone()
        {
            return new Smartphone(this.color, this.diagonal);
        }

        public void GetInfo()
        {
            Console.WriteLine("Samsung with color {0} and diagonal {1}",color, diagonal);
        }
    }
}