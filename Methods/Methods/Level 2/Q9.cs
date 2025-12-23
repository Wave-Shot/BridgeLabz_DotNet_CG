using System;

class NumberCheck
{
    public static bool IsPositive(int n)
    {
        if (n > 0)
            return true;
        else
            return false;
    }

    public static bool IsEven(int n)
    {
        if (n % 2 == 0)
            return true;
        else
            return false;
    }

    public static int Compare(int n1, int n2)
    {
        if (n1 > n2)
            return 1;
        else if (n1 == n2)
            return 0;
        else
            return -1;
    }

    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (IsPositive(arr[i]))
            {
                if (IsEven(arr[i]))
                    Console.WriteLine(arr[i] + " is Positive and Even");
                else
                    Console.WriteLine(arr[i] + " is Positive and Odd");
            }
            else
            {
                Console.WriteLine(arr[i] + " is Negative or Zero");
            }
        }
        int result = Compare(arr[0], arr[arr.Length - 1]);

        if (result == 1)
            Console.WriteLine("First element is greater than last element");
        else if (result == 0)
            Console.WriteLine("First and last elements are equal");
        else
            Console.WriteLine("First element is less than last element");
    }
}
