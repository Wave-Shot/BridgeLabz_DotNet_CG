using System;

class Level1Practice
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        int[] ages = new int[10];
        for (int i = 0; i < 10; i++)
            ages[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
                Console.WriteLine("Invalid age");
            else if (ages[i] >= 18)
                Console.WriteLine($"The student with the age {ages[i]} can vote");
            else
                Console.WriteLine($"The student with the age {ages[i]} cannot vote");
        }

        Console.WriteLine("Q2");
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
            numbers[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine("Positive Even");
                else
                    Console.WriteLine("Positive Odd");
            }
            else if (numbers[i] < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }

        if (numbers[0] == numbers[4])
            Console.WriteLine("First and Last elements are Equal");
        else if (numbers[0] > numbers[4])
            Console.WriteLine("First element is Greater");
        else
            Console.WriteLine("Last element is Greater");

        Console.WriteLine("Q3");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] table = new int[10];

        for (int i = 1; i <= 10; i++)
            table[i - 1] = num * i;

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} * {i} = {table[i - 1]}");

        Console.WriteLine("Q4");
        double[] values = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            double val = Convert.ToDouble(Console.ReadLine());
            if (val <= 0 || index == 10)
                break;
            values[index++] = val;
        }

        for (int i = 0; i < index; i++)
            total += values[i];

        Console.WriteLine(total);

        Console.WriteLine("Q5");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] multiplicationResult = new int[4];

        int idx = 0;
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[idx++] = number * i;
        }

        idx = 0;
        for (int i = 6; i <= 9; i++)
            Console.WriteLine($"{number} * {i} = {multiplicationResult[idx++]}");

        Console.WriteLine("Q6");
        double[] heights = new double[11];
        double sum = 0.0;

        for (int i = 0; i < 11; i++)
        {
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }

        Console.WriteLine(sum / 11);

        Console.WriteLine("Q7");
        int limit = Convert.ToInt32(Console.ReadLine());
        if (limit <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int[] even = new int[limit / 2 + 1];
        int[] odd = new int[limit / 2 + 1];
        int e = 0, o = 0;

        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 == 0)
                even[e++] = i;
            else
                odd[o++] = i;
        }

        for (int i = 0; i < e; i++)
            Console.WriteLine(even[i]);

        for (int i = 0; i < o; i++)
            Console.WriteLine(odd[i]);

        Console.WriteLine("Q8");
        int f = Convert.ToInt32(Console.ReadLine());
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int fi = 0;

        for (int i = 1; i <= f; i++)
        {
            if (f % i == 0)
            {
                if (fi == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    for (int j = 0; j < fi; j++)
                        temp[j] = factors[j];
                    factors = temp;
                }
                factors[fi++] = i;
            }
        }

        for (int i = 0; i < fi; i++)
            Console.WriteLine(factors[i]);

        Console.WriteLine("Q9");
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());

        int[] oneD = new int[rows * cols];
        int pos = 0;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                oneD[pos++] = matrix[i, j];

        for (int i = 0; i < oneD.Length; i++)
            Console.WriteLine(oneD[i]);

        Console.WriteLine("Q10");
        int fb = Convert.ToInt32(Console.ReadLine());
        if (fb <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        string[] result = new string[fb + 1];
        for (int i = 1; i <= fb; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result[i] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i] = "Fizz";
            else if (i % 5 == 0)
                result[i] = "Buzz";
            else
                result[i] = i.ToString();
        }

        for (int i = 1; i <= fb; i++)
            Console.WriteLine($"Position {i} = {result[i]}");
    }
}
