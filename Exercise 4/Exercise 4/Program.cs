class Program
{
    static void Main()
    {
        OutputFullName("Peter");
        OutputFullName("Allan", "Levsen");
    }

    static void OutputFullName(string firstName, string lastName = null)
    {

        if (lastName == null)
        {
            lastName = "";
        }
        string fullName = $"{firstName} {lastName}";
        Console.WriteLine(fullName);
    }
}
