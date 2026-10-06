namespace TrainingGround;

public class Employee : Person, IPrintable
{
    public Employee()
    {}

    public Employee(string name, string employeeId) : base(name)
    {
        this.EmployeeId = employeeId;
    }

    public string? EmployeeId { get; set; }

    public override string GetPrintString()
    {
        return @$"{this.Name} ({this.EmployeeId})
        {this.Address.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }
}