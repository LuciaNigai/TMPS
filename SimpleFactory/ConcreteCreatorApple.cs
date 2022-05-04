namespace SimpleFactory
{
    public class ConcreteCreatorApple : Creator
    {
        public override ProductPhone FactoryMethod()
        {
            return new ConcreteProductApple();
        }
    }
}