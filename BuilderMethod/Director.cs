namespace BuilderMethod
{
        class Director
        {
            BuilderPhone builder;
            public Director(BuilderPhone builder)
            {
                this.builder=builder;
            }
            public void Construct()
            {
                builder.BuildPhoneColor();
                builder.BuildPhoneMaterial();
                builder.BuildPhoneMemory();
            }
        }
}