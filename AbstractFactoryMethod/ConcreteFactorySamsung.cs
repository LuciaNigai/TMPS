namespace AbstractFactoryMethod
{
    class ConcreteFactorySamsung : AbstractFactory
    {
        public override Phone CreatePhone()
        {
            return new PhoneSamsung();
        }
        public override HeadPhones CreateHeadPhones()
        {
            return new HeadphonesSamsung();
        }
    }
}