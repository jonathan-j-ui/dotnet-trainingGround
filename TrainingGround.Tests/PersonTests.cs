using System.Reflection;

namespace TrainingGround.Tests;

public class PersonTests
{
    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {
        // act
        var p = new PersonTests();

        // assert
        Assert.NotNull(p);
    }
}