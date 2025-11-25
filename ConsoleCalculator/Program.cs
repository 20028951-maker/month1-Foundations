using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Console Calculator ===");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("Q) Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine()?.Trim().ToUpper();

            if (choice == "Q")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid number. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid number. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }

            double result;

            switch (choice)
            {
                case "1":
                    result = a + b;
                    Console.WriteLine($"Result: {a} + {b} = {result}");
                    break;
                case "2":
                    result = a - b;
                    Console.WriteLine($"Result: {a} - {b} = {result}");
                    break;
                case "3":
                    result = a * b;
                    Console.WriteLine($"Result: {a} * {b} = {result}");
                    break;
                case "4":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine($"Result: {a} / {b} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
