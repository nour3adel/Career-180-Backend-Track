using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Here are the options: \n1 - Addition \n2 - Subtraction \n3 - Multiplication \n4 - Division \n5 - Exit");
        Console.WriteLine("Input your choice:");

        int operation = int.Parse(Console.ReadLine());

        double result;

        switch (operation)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"The addition of {num1} and {num2} is: {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"The subtraction of {num1} and {num2} is: {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"The multiplication of {num1} and {num2} is: {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = (double)num1 / num2;
                    Console.WriteLine($"The division of {num1} by {num2} is: {result}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            case 5:
                Console.WriteLine("Exiting the program.");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}
