using System;

class Check
{
    public int Sign(int n)
    {
        if (n > 0)
        {
            return 1;
        }
        else if (n < 0)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Check signs = new Check();
        int result = signs.Sign(n);

        Console.WriteLine(result);
    }
}
