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
}