using System;

class Program
{
    static void Main()
    {
        bool isExerciseTwo = true;

        Console.WriteLine("Enter number 1 ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2 ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        double result = number2 * number1;

        Console.WriteLine("isExerciseTwo: " + isExerciseTwo);
        Console.WriteLine("number1: " + number1);
        Console.WriteLine("number2: " + number2);
        Console.WriteLine("The result of " + number1 + " multiplied by " + number2 + " is " + result);
    }
}