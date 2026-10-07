namespace TestingGround.Tests;

public class LinqTests
{
    [Fact]
    public void LinqToFilerNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }

    [Fact]
    public void LinqToFindFirst()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var firstNumberLargerThan15 = numbers.Find(number => number > 15);

        // assert
        Assert.Equal(53, firstNumberLargerThan15);
    }
}