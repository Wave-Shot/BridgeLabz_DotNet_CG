using System;

class RandomNumbers
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        int[] arr = new int[size];
        Random r = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = r.Next(1000, 10000);
        }

        return arr;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double avg = (double)sum / numbers.Length;
        return new double[] { avg, min, max };
    }

    static void Main()
    {
        int[] values = Generate4DigitRandomArray(5);

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }

        double[] result = FindAverageMinMax(values);

        Console.WriteLine("Average: " + result[0]);
        Console.WriteLine("Minimum: " + result[1]);
        Console.WriteLine("Maximum: " + result[2]);
    }
}
