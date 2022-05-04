namespace AbstractFactoryMethod
{
    class HeadphonesSamsung : HeadPhones
    {
        public override void Interact (Phone a)
        {
            Console.WriteLine(this.GetType().Name+" interacts with "+a.GetType().Name);
        }
    }
}