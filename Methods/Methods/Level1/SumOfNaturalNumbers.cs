using System;

class Sum
{
    static void Main()
    {
        Console.Write("Enter natural number n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Natural(n);
    }
    static void Natural(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum+=i;
        }
        Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);

    }
}
