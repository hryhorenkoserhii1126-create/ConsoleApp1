using System;

public class Program
{
    static void Main()
    {
        Console.Write("Запишіть периметр правильного трикутника: ");

        if (double.TryParse(Console.ReadLine(), out double P))
        {
            double a = P / 3.0;
            Console.WriteLine(a);
        }
    }
}