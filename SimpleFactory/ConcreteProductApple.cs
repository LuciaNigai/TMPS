namespace SimpleFactory
{
    public class ConcreteProductApple : ProductPhone
    {
        public override string Procesor()
        {
            Console.WriteLine("PhoneApple");
            return "Apple A14 Bionic";
        }
    }
}