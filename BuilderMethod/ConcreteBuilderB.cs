namespace BuilderMethod
{
        class ConcreteBuilderB : BuilderPhone
        {
            ProductPhone product = new ProductPhone();
            public override void BuildPhoneColor()
            {
                product.Add("White");
                Console.WriteLine("Phone color is white");
            }
            public override void BuildPhoneMaterial()
            {
                product.Add("Glass");
                Console.WriteLine("Phone material is Glass");
            }
            public override void BuildPhoneMemory()
            {
                product.Add("128");
                Console.WriteLine("Phone memory 128");
            }
            public override ProductPhone GetResult()
            {
                Console.WriteLine("Product is ready\n");
                return product;
            }
        }
}