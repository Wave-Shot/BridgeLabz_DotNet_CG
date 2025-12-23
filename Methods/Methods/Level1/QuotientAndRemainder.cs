using System;

class SmallestAndLargest
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int[] result = QuotientAndRemainder(n1, n2);

        Console.WriteLine("Quotient is " + result[0]);
        Console.WriteLine("Remainder is " + result[1]);
    }

    public static int[] QuotientAndRemainder(int n1, int n2)
    {
        int quotient = n1 / n2;
        int remainder = n1 % n2;

        return new int[] { quotient, remainder };
    }
}
