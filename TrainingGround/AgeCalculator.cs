using System.Reflection.Metadata.Ecma335;

namespace TrainingGround;

public class AgeCalculator
{
    static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }
}