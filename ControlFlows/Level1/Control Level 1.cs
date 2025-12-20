using System;

class LevelOne
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        int div = Convert.ToInt32(Console.ReadLine());
        if (div % 5 == 0)
        {
            Console.WriteLine("Divisible by 5");
        }

        Console.WriteLine("Q2");
        int a = 1;
        int b = 2;
        int c = 3;
        if (a < b && a < c)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine("Q3");
        if (a > b && a > c)
        {
            Console.WriteLine("a is the largest");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("b is the largest");
        }
        else
        {
            Console.WriteLine("c is the largest");
        }

        Console.WriteLine("Q4");
        int n = 2;
        if (n >= 0)
        {
            int n1 = n * (n + 1) / 2;
            Console.WriteLine($"Sum of {n} natural numbers is {n1}");
        }
        else
        {
            Console.WriteLine("Not a whole number");
        }

        Console.WriteLine("Q5");
        int age = 19;
        if (age >= 18)
        {
            Console.WriteLine("He/She can vote");
        }
        else
        {
            Console.WriteLine("Not allowed to vote");
        }

        Console.WriteLine("Q6");
        int n1Check = 5;
        if (n1Check > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (n1Check < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Your number is 0");
        }

        Console.WriteLine("Q7");
        String month = "June";
        int date = 21;
        if (
            (month == "March" && date > 20) ||
            month == "April" ||
            month == "May" ||
            (month == "June" && date < 20)
           )
        {
            Console.WriteLine("It is spring season");
        }
        else
        {
            Console.WriteLine("Not spring season");
        }

        Console.WriteLine("Q8");
        int count = Convert.ToInt32(Console.ReadLine());
        int tempCount = count;
        while (tempCount >= 1)
        {
            Console.WriteLine(tempCount);
            tempCount = tempCount - 1;
        }
        Console.WriteLine("Launch");

        Console.WriteLine("Q9");
        int tempCount2 = count;
        while (tempCount2 > 0)
        {
            tempCount2--;
        }
        Console.WriteLine("Launch");

        Console.WriteLine("Q10, Q11");
        int sum = 0;
        int number;
        Console.WriteLine("Enter numbers (enter 0 to stop):");
        while (true)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
                break;
            sum += number;
        }
        Console.WriteLine($"Sum of numbers is {sum}");

        Console.WriteLine("Q12,13");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int loopSum = 0;
        for (int i = 1; i <= n2; i++)
        {
            loopSum += i;
        }
        int n3 = n2 * (n2 + 1) / 2;
        if (loopSum == n3)
        {
            Console.WriteLine("Formula holds");
        }

        Console.WriteLine("Q14, Q15");
        int factorialNumber = 5;
        int factorial = 1;
        for (int i = 1; i <= factorialNumber; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);

        Console.WriteLine("Q16");
        int user = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= user; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even number");
            }
            else
            {
                Console.WriteLine($"{i} is an odd number");
            }
        }

        Console.WriteLine("Q17");
        int sal = Convert.ToInt32(Console.ReadLine());
        int years = Convert.ToInt32(Console.ReadLine());
        if (years > 5)
        {
            sal = sal + (sal * 5 / 100);
            Console.WriteLine($"{sal} is your total salary this year");
        }

        Console.WriteLine("Q18");
        int number1 = Convert.ToInt32(Console.ReadLine());
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number1} * {i} = {number1 * i}");
        }
    }
}
