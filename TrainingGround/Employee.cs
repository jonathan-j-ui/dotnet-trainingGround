namespace TrainingGround;

public class Employee : Person, IPrintable
{
    public Employee()
    {
        this.Addresses = new List<Address>();
    }

    public Employee(string name, string employeeId) : base(name)
    {
        this.EmployeeId = employeeId;
        this.Addresses = new List<Address>();
    }

    public List<Address> Addresses { get; set; }

    public string? EmployeeId { get; set; }

    public override string GetPrintString()
    {
        return @$"{this.Name} ({this.EmployeeId})
        {this.Address.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }
}