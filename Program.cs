using System;

class Program
{
    static void Main()
    {
        double num1;
        double num2;

        // Ask for first number
        Console.WriteLine("Enter first number:");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        // Ask for second number
        Console.WriteLine("Enter second number:");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        // Ask for operation
        Console.WriteLine("Choose operation (+, -, *, /):");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return;
                }
                break;

            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}