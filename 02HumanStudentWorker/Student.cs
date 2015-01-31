using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber 
    {
        get 
        {
            return this.facultyNumber;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Length >= 5 && value.Length <= 10)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Faculty number must contain more than 5 and less than 10 characters.");
                }
            }
            else
            {
                throw new ArgumentNullException("Faculty number cannot be null or empty.");
            }
        }
    }
}