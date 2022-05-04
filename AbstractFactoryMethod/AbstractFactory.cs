namespace AbstractFactoryMethod
{
    abstract class AbstractFactory
    {
        public abstract Phone CreatePhone();
        public abstract HeadPhones CreateHeadPhones();
    }
}