abstract class Person : IDetails
{
    public string Details { get; set; }

    public string Name { get; set; }

    internal global::IDetails IDetails
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }
}
