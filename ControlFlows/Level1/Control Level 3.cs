using System;

class Level3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum = sum + (digit * digit * digit);
            originalNumber = originalNumber / 10;
        }

        if (sum == number)
        {
            Console.WriteLine("Armstrong Number");
        }
        else
        {
            Console.WriteLine("Not an Armstrong Number");
        }

        Console.WriteLine("Q2");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        while (number2 != 0)
        {
            number2 = number2 / 10;
            count++;
        }

        Console.WriteLine(count);

        Console.WriteLine("Q3");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int sum2 = 0;
        int temp = number3;

        while (temp != 0)
        {
            sum2 = sum2 + (temp % 10);
            temp = temp / 10;
        }

        if (number3 % sum2 == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }

        Console.WriteLine("Q4");
        int number4 = Convert.ToInt32(Console.ReadLine());
        int sum3 = 0;

        for (int i = 1; i < number4; i++)
        {
            if (number4 % i == 0)
            {
                sum3 = sum3 + i;
            }
        }

        if (sum3 > number4)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }

        Console.WriteLine("Q5");
        int m = Convert.ToInt32(args[0]);
        int d = Convert.ToInt32(args[1]);
        int y = Convert.ToInt32(args[2]);

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine(d0);

        Console.WriteLine("Q6");
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine(first + second);
                break;
            case "-":
                Console.WriteLine(first - second);
                break;
            case "*":
                Console.WriteLine(first * second);
                break;
            case "/":
                Console.WriteLine(first / second);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }

        Console.ReadLine();
    }
}
