using System;

class TriangularParkRun
{
    public static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;
        return rounds;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);

        Console.WriteLine("Number of rounds needed to complete 5 km: " + rounds);
    }
}
