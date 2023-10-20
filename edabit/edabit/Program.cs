using System;


public class Program
{
    private static void Main(string[] args)
    {
        bool i= true;
        double a = Convert.ToDouble(Console.ReadLine());
        if (a > 0)
        {
            i= false;
            Console.WriteLine(i);
        }
        else
        {
            Console.WriteLine(i);
        }
    }

}