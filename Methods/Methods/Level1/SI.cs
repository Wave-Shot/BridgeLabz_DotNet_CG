using System;

class SimpleInterest
{
    public int Interest(int p, int r, int t)
    {
        int interest = p * r * t / 100;
        return interest;
    }

    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine());
        int r = Convert.ToInt32(Console.ReadLine());
        int t = Convert.ToInt32(Console.ReadLine());

        SimpleInterest si = new SimpleInterest();
        int interest = si.Interest(p, r, t);     
        Console.WriteLine(interest);
    }
}
