namespace TrainingGround;

public class Person
{
    private string _name;
    private int _birthYear;
    private double _lengthInMeters;

    public Person(string _name)
    {
        this._name = _name;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length > 5)
            {
                this._name = value;
            }
        }
    }

    public int BirthYear
    {
        get { return _birthYear; }
        set
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

    public int GetAge(int currentYear)
    {
        return currentYear - _birthYear;
    }

}