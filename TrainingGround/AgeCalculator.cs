using System.Reflection.Metadata.Ecma335;

namespace TrainingGround;

public enum AgeCategory
{
    Kid,
    Adult,
    Prime
}

public class AgeCalculator
{
    public static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person, int currentYear)
    {
        var age = person.GetAge(currentYear);

        if (age == 50)
        {
            return AgeCategory.Prime;
        }
        else if (age <= 18)
        {
            return AgeCategory.Kid;
        }
        return AgeCategory.Adult;
    }

    public static string GetAgeSpan(AgeCategory category)
    {
        switch (category)
        {
            case AgeCategory.Kid:
                return "18 years or below";
            case AgeCategory.Adult:
                return "19 years and above";
            case AgeCategory.Prime:
                return "50 years";
            default:
                return "Unknown age span";
        }
    }
}