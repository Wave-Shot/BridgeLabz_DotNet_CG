using System;

class NumberCheck
{
    public static bool IsPositive(int n)
    {
        return n > 0;
    }

    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    public static int Compare(int a, int b)
    {
        if (a > b) return 1;
        if (a == b) return 0;
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (IsPositive(arr[i]))
            {
                if (IsEven(arr[i]))
                {
                    Console.WriteLine(arr[i] + " is Positive and Even");
                }
                else
                {
                    Console.WriteLine(arr[i] + " is Positive and Odd");
                }
            }
            else
            {
                Console.WriteLine(arr[i] + " is Negative");
            }
        }

        int result = Compare(arr[0], arr[arr.Length - 1]);

        if (result == 1)
        {
            Console.WriteLine("First element is greater than last element");
        }
        else if (result == 0)
        {
            Console.WriteLine("First and last elements are equal");
        }
        else
        {
            Console.WriteLine("First element is less than last element");
        }
    }
}
