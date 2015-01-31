﻿public abstract class Human
{
    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
}
