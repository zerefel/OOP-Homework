using System;

public class Worker : Human
{
    private decimal weekSalary;
    private double dailyWorkHours;

    public Worker(string firstName, string lastName, decimal weekSalary, double dailyWorkHours) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.DailyWorkHours = dailyWorkHours;
    }

    public decimal WeekSalary 
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value > 0)
            {
                this.weekSalary = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Salary cannot be 0 or negative. This is not Bulgaria.");

            }
        }
    }
    public double DailyWorkHours
    {
        get
        {
            return this.dailyWorkHours;
        }
        set
        {
            if (value > 0)
            {
                this.dailyWorkHours = value;
            }
            else
            {
                throw new ArgumentNullException("Work Hours cannot be 0 or negative. This is not Bulgaria.");
            }
        }
    }

    public decimal MoneyPerHour()
    {
        decimal dailyPayment = weekSalary / 5;
        decimal hourlyPayment = dailyPayment / (decimal)this.DailyWorkHours;
        return hourlyPayment;
    }
}