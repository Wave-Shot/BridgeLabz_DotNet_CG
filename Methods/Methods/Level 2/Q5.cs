using System;

class Conversion
{
    public static double ConvertYardsToFeet(double yards)
    {
        double feet = 3 * yards;
        return feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double yard = 0.33 * feet;
        return yard;
    }

    public static double ConvertMetresToInches(double metres)
    {
        double inches = 39.3701 * metres;
        return inches;
    } 

    public static double ConvertInchesToMetres(double inch)
    {
        double metre = 0.0254 * inch;
        return metre;
    }
    
    public static double ConvertInchesToCentiMetres(double inch)
    {
        double cm = 2.54 * inch;
        return cm;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter choice:");
        Console.WriteLine("1. Yards to Feet");
        Console.WriteLine("2. Feet to Yards");
        Console.WriteLine("3. Metres to Inches");
        Console.WriteLine("4. Inches to Metres");
        Console.WriteLine("5. Inches to Centimetres");

        int n = Convert.ToInt32(Console.ReadLine());
        double value;

        if (n == 1)
        {
            Console.Write("Enter yards: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertYardsToFeet(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 2)
        {
            Console.Write("Enter feet: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertFeetToYards(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 3)
        {
            Console.Write("Enter metres: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertMetresToInches(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 4)
        {
            Console.Write("Enter inches: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertInchesToMetres(value);
            Console.WriteLine("Your answer is " + result);
        }
        else if (n == 5)
        {
            Console.Write("Enter inches: ");
            value = Convert.ToDouble(Console.ReadLine());
            double result = ConvertInchesToCentiMetres(value);
            Console.WriteLine("Your answer is " + result);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
