using System;

class Year
{
    static bool LeapYear(int n)
    {
        if (n < 1582)
        {
            Console.WriteLine("Write a year greater than 1582");
            return false;
        }

        if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool result = LeapYear(n);
        Console.WriteLine("Is leap year: " + result);
    }
}
