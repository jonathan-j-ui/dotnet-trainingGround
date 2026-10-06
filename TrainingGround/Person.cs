namespace TrainingGround;

public class Person
{
    private string Name;
    private int birthYear;
    private double LengthInMeters;

    public Person(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return this.Name;
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