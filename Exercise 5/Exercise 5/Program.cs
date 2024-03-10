class Program
{
    static void Main()
    {

        Console.WriteLine(GetAgeStatus(4));
        Console.WriteLine(GetAgeStatus(15));
        Console.WriteLine(GetAgeStatus(24));
        Console.WriteLine(GetAgeStatus(65));
        Console.WriteLine(GetAgeStatus(80));
        Console.WriteLine(GetAgeStatus(-1));
        Console.WriteLine(GetAgeStatus(200));
    }

    static string GetAgeStatus(int age)
    {
        if (age < 1 || age > 100)
        {
            return "Unknown";
        }
        else if (age < 6)
        {
            return "Toddler";
        }
        else if (age < 18)
        {
            return "Teen";
        }
        else if (age < 65)
        {
            return "Adult";
        }
        else
        {
            return "Senior";
        }
    }
}
