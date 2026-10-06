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

    public void APersonBornIn1972_Is50_In2022()
    {
        // arrange
        var p = new Person();
        p.BirthYear = 1972;

        // act
        var age = p.getAge();

        // assert
        Assert.Equal(50, age);
    }
}