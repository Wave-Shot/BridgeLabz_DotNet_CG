using System;

class Level2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q0, Q1");
        int LeapYear = Convert.ToInt32(Console.ReadLine());
        if (LeapYear % 4 == 0 && LeapYear % 100 != 0 || LeapYear % 400 == 0)
        {
            Console.WriteLine($"{LeapYear} is a leap year");
        }
        else
        {
            Console.WriteLine($"{LeapYear} is not a leap year");
        }

        Console.WriteLine("Q2");
        int g1 = Convert.ToInt32(Console.ReadLine());
        int g2 = Convert.ToInt32(Console.ReadLine());
        int g3 = Convert.ToInt32(Console.ReadLine());
        int average = (g1 + g2 + g3) / 3;

        if (average >= 80)
        {
            Console.WriteLine("Grade is A. Level 4..");
        }
        else if (average >= 70)
        {
            Console.WriteLine("Grade is B. Level 3..");
        }
        else if (average >= 60)
        {
            Console.WriteLine("Grade is C. Level 2..");
        }
        else if (average >= 50)
        {
            Console.WriteLine("Grade is D. Level 1..");
        }
        else
        {
            Console.WriteLine("Below industry standards..");
        }

        Console.WriteLine("Q3");
        int prime = Convert.ToInt32(Console.ReadLine());

        if (prime < 2)
        {
            Console.WriteLine("Not a prime number");
        }
        else
        {
            bool isPrime = true;

            for (int i = 2; i <= prime / 2; i++)
            {
                if (prime % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
        }

        Console.WriteLine("Q4, Q5");
        int Fizz = Convert.ToInt32(Console.ReadLine());
        if (Fizz > 0)
        {
            for (int i = 1; i <= Fizz; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Enter a positive integer");
        }

        Console.WriteLine("Q6");
        double weight = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());
        double height2 = height / 100;
        double BMI = weight / (height2 * height2);

        if (BMI <= 18.4)
        {
            Console.WriteLine("Underweight");
        }
        else if (BMI <= 24.9)
        {
            Console.WriteLine("Healthy");
        }
        else if (BMI <= 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }

        Console.WriteLine("Q7");
        int age1 = Convert.ToInt32(Console.ReadLine());
        int age2 = Convert.ToInt32(Console.ReadLine());
        int age3 = Convert.ToInt32(Console.ReadLine());
        int height1 = Convert.ToInt32(Console.ReadLine());
        int height4 = Convert.ToInt32(Console.ReadLine());
        int height3 = Convert.ToInt32(Console.ReadLine());

        if (age1 > age2 && age1 > age3)
        {
            Console.WriteLine("Age1 is older");
        }
        else if (age2 > age1 && age2 > age3)
        {
            Console.WriteLine("Age2 is older");
        }
        else
        {
            Console.WriteLine("Age3 is older");
        }

        if (height1 > height4 && height1 > height3)
        {
            Console.WriteLine("Height1 is taller");
        }
        else if (height4 > height3 && height4 > height1)
        {
            Console.WriteLine("Height2 is taller");
        }
        else
        {
            Console.WriteLine("Height3 is taller");
        }

        Console.WriteLine("Q8");
        int number = Convert.ToInt32(Console.ReadLine());
        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine($"Greatest factor of {number} is {greatestFactor}");

        Console.WriteLine("Q9");
        int number5 = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());
        int result5 = 1;

        for (int i = 1; i <= power; i++)
        {
            result5 = result5 * number5;
        }
        Console.WriteLine(result5);

        Console.WriteLine("Q10");
        int number6 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < number6; i++)
        {
            if (number6 % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Q11");
        int number7 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 100; i++)
        {
            if (i % number7 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();

    }
}
