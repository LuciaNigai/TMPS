namespace AbstractFactoryMethod
{
    class Client
    {
        private Phone phone;
        private HeadPhones headphones;

        public Client (AbstractFactory factory)
        {
            headphones = factory.CreateHeadPhones();
            phone = factory.CreatePhone();
        }

        public void Run()
        {
            headphones.Interact(phone);
        }
    }
}