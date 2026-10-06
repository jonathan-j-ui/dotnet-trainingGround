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
        get;
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
        get;
        set;
    }

    public double LengthInMeters
    {
        get;
        set;
        
    }

}