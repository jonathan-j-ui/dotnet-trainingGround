namespace TrainingGround.Tests;

public class LoopTests
{
    [Fact]
    public void WhileLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        // act
        var i = 0;
        while (i < ints.Length )
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            // assert
            Assert.Equal(i + 1, currentValueInTheLoop);

            i++;
        }
    }

    [Fact]
    public void ForLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        // act
        for (var i = 0; i < ints.Length; i++)
        {
            var currentValueInTheLoop = ints[i];

            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            // assert
            Assert.Equal(i + 1, currentValueInTheLoop);
        }
    }

    [Fact]
    public void ForEachLoop_UsingAddresses()
    {
        // arrange
        var emp = new Employee("Person 1", "XXX11-XX");

        // act
        emp.Addresses.Add(new Address{ Street = "Street", StreetNo = 1, City = "Stockholm" });
        emp.Addresses.Add(new Address{ Street = "Street", StreetNo = 2, City = "Stockholm" });
        emp.Addresses.Add(new Address{ Street = "Street", StreetNo = 3, City = "Stockholm" });

        int i = 0;

        foreach (var address in emp.Addresses)
        {
            // assert
            Assert.Equal(i + 1, address.StreetNo);


            i++;
        }
    }
}