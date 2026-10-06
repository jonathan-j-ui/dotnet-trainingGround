namespace TrainingGround;

public class Person
{
    private string _name;
    private int birthYear;
    private double LengthInMeters;

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

    public int GetBirthYear()
    {
        return this.birthYear;
    }

    public double GetLengthInMeters()
    {
        return this.LengthInMeters;
    }

}