using System;

class Trigonometry
{
    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine value: " + result[0]);
        Console.WriteLine("Cosine value: " + result[1]);
        Console.WriteLine("Tangent value: " + result[2]);
    }
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}
