using System;

class Chill
{
    static void Main()
    {
        Console.Write("Enter Wind Speed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        double result = WindChill(windSpeed, temp);

        Console.WriteLine("Wind Chill is: " + result);
    }

    public static double WindChill(double windSpeed, double temp)
    {
        double windChill =
            35.74 + 0.6215 * temp +
            (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }
}
