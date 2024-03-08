using System;

class Program
{
    static void Main()
    {
        Person person = new Person
        {
            PersonId = 1,
            PersonType = PersonType.Owner,
            FirstName = "Shivam",
            LastName = "Mehta"
        };

        Console.WriteLine($"Person ID: {person.PersonId}");
        Console.WriteLine($"Person Type: {person.PersonType}");
        Console.WriteLine($"First Name: {person.FirstName}");
        Console.WriteLine($"Last Name: {person.LastName}");
    }
}
