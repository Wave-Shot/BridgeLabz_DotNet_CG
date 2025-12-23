using System;

class FriendsComparison
{
    static string FindYoungest(int[] ages, string[] names)
    {
        int minAge = ages[0];
        string youngest = names[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngest = names[i];
            }
        }

        return youngest;
    }
    static string FindTallest(double[] heights, string[] names)
    {
        double maxHeight = heights[0];
        string tallest = names[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                tallest = names[i];
            }
        }

        return tallest;
    }

    public static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + " (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        string youngestFriend = FindYoungest(ages, names);
        string tallestFriend = FindTallest(heights, names);

        Console.WriteLine("\nYoungest friend is: " + youngestFriend);
        Console.WriteLine("Tallest friend is: " + tallestFriend);
    }
}
