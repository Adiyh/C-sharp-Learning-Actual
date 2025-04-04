using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }
        Console.WriteLine("Result: " + result);
    }
}

   