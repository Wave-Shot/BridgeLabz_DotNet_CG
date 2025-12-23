using System;

class Handshakes
{
    public int Handshake(int n)
    {
        int combination = (n * (n - 1)) / 2;
        return combination;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Handshakes shake = new Handshakes();
        int number = shake.Handshake(n);

        Console.WriteLine(number);
    }
}
