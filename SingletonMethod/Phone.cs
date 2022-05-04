namespace SingletonMethod
{
class Phone
{
    private static Phone instance=null;
    public string Color;
 
    protected Phone(string color)
    {
        this.Color=color;
    }
 
    public static Phone getInstance(string color)
    {
        if (instance == null)
            instance = new Phone(color);
        return instance;
    }
}
}