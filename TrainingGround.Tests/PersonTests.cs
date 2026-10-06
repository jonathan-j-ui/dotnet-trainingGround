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

    [Fact]
    public void APersonBornIn1972_Is50_In2022()
    {
        // arrange
        var p = new Person("Jonathan", 1972);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
    }
}