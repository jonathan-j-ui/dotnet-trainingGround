using System.Net.Sockets;
using System.Reflection;

namespace TrainingGround.Tests;

public class PersonTests
{

    [Fact]
    public void ConstructorWithName_CreatesPerson()
    {
        // act
        var p = new Person("Jonathan");

        // assert
        Assert.Equal("Jonathan", p.Name);
    }

    [Theory]
    [InlineData(1982,2022,40)]
    [InlineData(1992,2022,30)]
    [InlineData(2022,2022,0)]
    public void APersonBornInXXXX_IsYY_InZZZZ(int birthYear, int currentYear, int expectedAge)
    {
        // arrange
        var p = new Person("Jonathan", birthYear);

        // act
        var age = p.GetAge(currentYear);

        // assert
        Assert.Equal(expectedAge, age);
    }

    [Fact]
    public void AnEmployeeIsAPerson()
    {
        // arrange


        // act
        var emp = new Employee();
        emp.LengthInMeters = 1.95;

        // assert
        Assert.IsType<Employee>(emp);
        Assert.Equal(1.95, emp.LengthInMeters);
    }

    [Fact]
    public void AnEmployeeHasAnEmployeeId()
    {
        // act
        var emp = new Employee("Jonathan", "234-BDAS");

        // assert
        Assert.IsType<Employee>(emp);
        Assert.Equal("Jonathan", emp.Name);
        Assert.Equal("234-BDAS", emp.EmployeeId);
    }

    [Fact]
    public void APersonHasAnAdress()
    {
        // arrange
        var p = new Person("Jonathan");

        // act
        p.Address = new Address();
        p.Address.Street = "A street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // assert
        Assert.NotNull(p.Address);
        Assert.IsType<Address>(p.Address);

        Assert.Equal("A street", p.Address.Street);
        Assert.Equal(23, p.Address.StreetNo);
        Assert.Equal("Stockholm", p.Address.City);
    
    }

    [Fact]
    public void AnEmployeeGetPrintString_GetANicePrintedAddress()
    {
        // arrange
        var emp = new Employee("Jonathan", "234-BDAS");
        emp.Address = new Address;
        emp.Address.Street = "A street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

        // assert
        Assert.Equal(@"Jonathan (234-BDAS)
        A Street 23
        Stockholm",
        printString);
    }

}