using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        PrintEvenNumbersUpTo(n);
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static void PrintEvenNumbersUpTo(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            if (IsEven(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
