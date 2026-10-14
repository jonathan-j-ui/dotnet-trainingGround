using TrainingGround;

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

    [Fact]
    public void LinqToCheckIfAnyMatches()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var anyOver100 = numbers.Any(number => number > 100);

        // assert
        Assert.False(anyOver100);
    }

    [Fact]
    public void FilterPeopleByNameLength_ReturnCorrectList()
    {
        // arrange
        var people = new List<Person>
        {
            new Person("Aaaron"),
            new Person("Bea"),
            new Person ("Ceasar"),
            new Person("Dave")
        };

        // act
        var allWithLongNames = people
            .Where(p => p.Name.Length > 4)
            .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaaron", allWithLongNames[0].Name);
    }

    [Fact]
    public void FilterPeopleByNameLengthAndSelect_ReturnCorrectList()
    {
        // arrange
        var people = new List<Person>
        {
            new Person("Aaaron"),
            new Person("Bea"),
            new Person ("Ceasar"),
            new Person("Dave")
        };

        // act
        var allWithLongNames = people
            .Where(p => p.Name.Length > 4)
            .Select(p => p.Name)
            .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaaron", allWithLongNames[0]);
        Assert.Equal("Ceasar", allWithLongNames[1]);
    }

    [Fact]
    public void LinqOrderNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var orderedNumbers = numbers.OrderBy(num => num).ToList();

        // assert
        Assert.Equal(2, orderedNumbers[1]);
    }

    [Fact]
    public void FilterPeopleByNameLengthAndSelectByLength_ReturnCorrectList()
    {
        // arrange
        var a = new Person("Aaaron");
        a.LengthInMeters = 1.96;
        var people = new List<Person>
        {
            a,
            new Person("Bea"),
            new Person ("Ceasar"),
            new Person("Dave")
        };

        // act
        var query =
            from p in people
            where p.Name.Length > 4
            select new { Name = p.Name, Height = p.LengthInMeters };
        var namesAndHeights = query.ToList();

        // assert
        Assert.Equal(2, namesAndHeights.Count);
        Assert.Equal("Aaaron", namesAndHeights[0].Name);
        Assert.Equal(1.96, namesAndHeights[0].Height);
    }
}