using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors are:");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Sum of factors: " + FindSum(factors));
        Console.WriteLine("Product of factors: " + FindProduct(factors));
        Console.WriteLine("Sum of squares of factors: " + FindSumOfSquares(factors));
    }

    static int[] FindFactors(int num)
    {
        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    static int FindSum(int[] factors)
    {
        int sum = 0;

        for (int i = 0; i < factors.Length; i++)
        {
            sum = sum + factors[i];
        }

        return sum;
    }

    static int FindProduct(int[] factors)
    {
        int product = 1;

        for (int i = 0; i < factors.Length; i++)
        {
            product = product * factors[i];
        }

        return product;
    }
    static double FindSumOfSquares(int[] factors)
    {
        double sum = 0;

        for (int i = 0; i < factors.Length; i++)
        {
            sum = sum + Math.Pow(factors[i], 2);
        }

        return sum;
    }
}
