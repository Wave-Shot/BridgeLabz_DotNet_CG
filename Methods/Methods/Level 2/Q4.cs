using System;

class Conversion
{
    public static double ConvertKmToMiles(double km)
    {
        double miles = km * 0.621371;
        return miles;
    }

    public static double ConvertMilesTokm(double mile)
    {
        double kms = mile * 1.60934;
        return kms;
    }

    public static double ConvertMetresToFeet(double metres)
    {
        double feet = metres * 3.28084;
        return feet;
    }

    public static double ConvertFeetToMetres(double metre)
    {
        double feets = metre * 0.3048;
        return feets;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter choice:");
        Console.WriteLine("1. Km to Miles");
        Console.WriteLine("2. Miles to Km");
        Console.WriteLine("3. Metres to Feet");
        Console.WriteLine("4. Feet to Metres");

        int n = Convert.ToInt32(Console.ReadLine());
        double value; 

        if (n == 1)
        {
            Console.Write("Enter kilometers: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertKmToMiles(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 2)
        {
            Console.Write("Enter miles: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertMilesTokm(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 3)
        {
            Console.Write("Enter metres: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertMetresToFeet(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 4)
        {
            Console.Write("Enter feet: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertFeetToMetres(value);
            Console.WriteLine("Your answer is " + result);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
