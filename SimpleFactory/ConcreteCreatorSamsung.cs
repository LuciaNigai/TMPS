namespace SimpleFactory
{
    public class ConcreteCreatorSamsung : Creator
    {
        public override ProductPhone FactoryMethod()
        {
            return new ConcreteProductSamsung();
        }
    }
}