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
        Assert.Equal("Jonathan", p.GetName());
    }
}