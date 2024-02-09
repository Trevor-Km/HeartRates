using System;



public class HealthProfile
{
    public HealthProfile(){ 
    private string firstName;
    private string lastName;
    private int birthYear;
    private int currentYear;
    private int height;
    private int weight;



    public HealthProfile(string firstName, string lastName, int birthYear, int currentYear, int height, int weight)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.BirthYear = birthYear;
        this.CurrentYear = currentYear;
        this.height =

    }

    public HealthProfile()
    {
    }
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;
        }
    }

    public int BirthYear
    {
        get
        {
            return birthYear;
        }
        set
        {
            birthYear = value;
        }
    }
    public int CurrentYear
    {
        get
        {
            return currentYear;
        }
        set
        {
            currentYear = value;
        }
    }

    public int Height
    {
        get { return height; }

        set
        {
            height = value;
        }
    }


    public int Weight
    {

        get
        {
            return weight;
        }

        set
        {
            weight = value;
        }
    }
    public int CalculateAge
    {
        get
        {
            return currentYear - birthYear;
        }
    }

    public int CalculateMaxHR
    {
        get
        {
            return 220 - CalcAge;
        }
    }

    public double MinTargetHR
    {
        get
        {
            return CalcMaxHR * 0.5;
        }
    }

    public double MaxTargetHR
    {
        get
        {
            return CalcMaxHR * 0.85;
        }
    }
}

}
}
