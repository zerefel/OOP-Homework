using System;

public abstract class Animal : ISound
{
    protected Animal(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }

    public abstract void ProduceSound();
}