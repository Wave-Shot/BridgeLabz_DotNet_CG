using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number. Exiting program.");
            return;
        }

        int recursiveSum = SumUsingRecursion(n);
        int formulaSum = SumUsingFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);

        if (recursiveSum == formulaSum)
            Console.WriteLine("Both results are correct and equal.");
        else
            Console.WriteLine("Results are not equal.");
    }

    static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1;

        return n + SumUsingRecursion(n - 1);
    }

    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
