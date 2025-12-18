using System;

public class Practice
{
    public static void Main()
    {
        Console.Write("Enter radius: ");
        string? radius = Console.ReadLine();

        if (double.TryParse(radius, out double r))
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of circle = {0}", area);
        }
        else
        {
            Console.WriteLine("Please enter a valid integer radius");
        }
    }
}
