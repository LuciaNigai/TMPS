namespace AbstractFactoryMethod
{
    class ConcreteFactoryApple : AbstractFactory
    {
        public override Phone CreatePhone()
        {
            return new PhoneApple();
        }
        public override HeadPhones CreateHeadPhones()
        {
            return new HeadphonesApple();
        }
    }
}