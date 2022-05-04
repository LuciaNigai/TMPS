namespace SimpleFactory
{
    public class ConcreteProductSamsung : ProductPhone
    {
        public override string Procesor()
        {
            Console.WriteLine("PhoneSamsung");
            return "ARM Cortex-A75";
        }
    }
}