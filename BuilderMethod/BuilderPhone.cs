namespace BuilderMethod
{
        abstract class BuilderPhone
        {
            public abstract void BuildPhoneColor();
            public abstract void BuildPhoneMaterial();
            public abstract void BuildPhoneMemory();
            public abstract ProductPhone GetResult();
        }
}