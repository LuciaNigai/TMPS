namespace BuilderMethod
{
        class ConcreteBuilderA : BuilderPhone
        {
            ProductPhone product = new ProductPhone();
            public override void BuildPhoneColor()
            {
                product.Add("Blue");
                Console.WriteLine("Phone color Blue");
            }
            public override void BuildPhoneMaterial()
            {
                product.Add("Glass");
                Console.WriteLine("Phone Material Glass");
            }
            public override void BuildPhoneMemory()
            {
                product.Add("64");
                Console.WriteLine("Phone memory 64");
            }
            public override ProductPhone GetResult()
            {
                Console.WriteLine("Product is ready\n");
                return product;
            }
        }
}