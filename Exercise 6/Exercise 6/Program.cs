class Program
{
    static void Main()
    {
        string numbers = "";
        for (int i = 0; i < 10; i++)
        {
            numbers += i;
        }

        Console.WriteLine($"Numbers: {numbers}");

        Console.WriteLine("Numbers output using foreach: ");
        foreach (char digit in numbers.ToCharArray())
        {
            Console.Write($"{digit}");
        }
    }
}
