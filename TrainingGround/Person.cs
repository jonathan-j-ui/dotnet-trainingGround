namespace TrainingGround;

public class Person
{
    private string? _name;
    private int _birthYear;
    private double _lengthInMeters;

    public Person(){
        
    }

    public Person(string name)
    {
        this._name = name;
    }

    public Person(string name, int birthYear)
    {
        this._name = name;
        this._birthYear = birthYear;
    }

    public string? Name
    {
        get { return _name; }
        set
        {
            if (value is not null && value.Length > 5)
            {
                this._name = value;
            }
        }
    }

    public int BirthYear
    {
        get { return _birthYear; }
        private set
        {
            this._birthYear = value;
        }
    }

    public double LengthInMeters
    {
        get { return _lengthInMeters; }
        set
        {
            this._lengthInMeters = value;
        }
        
    }

    public Address Address { get; set; }

    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }

}