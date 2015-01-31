class Student : Person
{
    public string ClassNumber { get; set; }

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