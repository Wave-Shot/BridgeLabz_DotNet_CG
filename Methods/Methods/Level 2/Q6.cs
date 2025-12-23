using System;
class UnitConvertor
{
    public static double convertFarhenheitToCelsius(double farhenheit)
    {
        double celsius =  (farhenheit - 32) * 5 / 9;
        return celsius;
    }

    public static double convertCelsiusToFarenhit(double celsius)
    {
        double farhenheit = (celsius * 9 / 5) + 32;
        return farhenheit;
    }

     public static double convertPoundsToKg(double kg)
    {
        double pounds = 0.453592* kg;
        return pounds;
    }
    
     public static double convertKgToPounds(double pounds)
    {
        double kg = 2.20462 * pounds;
        return kg; 
    }

    public static double convertGallonsToLitres(double Litres)
    {
        double gallons =  3.78541 * Litres;
        return gallons;
    }

    public static double convertLitresToGallons(double gallons)
    {
        double Litres =  0.264172 * gallons;
        return Litres; 
    }

    public static void Main(string[] args)
{
    Console.WriteLine("Choose conversion:");
    Console.WriteLine("1. Fahrenheit to Celsius");
    Console.WriteLine("2. Celsius to Fahrenheit");
    Console.WriteLine("3. Pounds to Kg");
    Console.WriteLine("4. Kg to Pounds");
    Console.WriteLine("5. Gallons to Litres");
    Console.WriteLine("6. Litres to Gallons");

    int choice = Convert.ToInt32(Console.ReadLine());
    double value, result;

    if (choice == 1)
    {
        Console.Write("Enter Fahrenheit: ");
        value = Convert.ToDouble(Console.ReadLine());
        result = convertFarhenheitToCelsius(value);
        Console.WriteLine("Result: " + result);
    }
    else if (choice == 2)
    {
        Console.Write("Enter Celsius: ");
        value = Convert.ToDouble(Console.ReadLine());
        result = convertCelsiusToFarenhit(value);
        Console.WriteLine("Result: " + result);
    }
    else if (choice == 3)
    {
        Console.Write("Enter Pounds: ");
        value = Convert.ToDouble(Console.ReadLine());
        result = convertPoundsToKg(value);
        Console.WriteLine("Result: " + result);
    }
    else if (choice == 4)
    {
        Console.Write("Enter Kg: ");
        value = Convert.ToDouble(Console.ReadLine());
        result = convertKgToPounds(value);
        Console.WriteLine("Result: " + result);
    }
    else if (choice == 5)
    {
        Console.Write("Enter Gallons: ");
        value = Convert.ToDouble(Console.ReadLine());
        result = convertGallonsToLitres(value);
        Console.WriteLine("Result: " + result);
    }
    else if (choice == 6)
    {
        Console.Write("Enter Litres: ");
        value = Convert.ToDouble(Console.ReadLine());
        result = convertLitresToGallons(value);
        Console.WriteLine("Result: " + result);
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}
    
}