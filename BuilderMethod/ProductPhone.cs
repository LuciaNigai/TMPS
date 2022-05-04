namespace BuilderMethod
{
        class ProductPhone
        {
            List<object> parts = new List<object>();
            public void Add(string part)
            {
                parts.Add(part);
            }
        }
}