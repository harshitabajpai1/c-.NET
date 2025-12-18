using System;
public class Prime
{
    public static void Main()
    {
        
        Console.Write("enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Boolean flag =false;

        for(int i = 2;i*i<num; i++)
        {
            if (num % i == 0)
            {
                flag = true;
                break;
            }
        }
        if(flag == false)
        {
            Console.WriteLine("prime");
        }
        else
        {
            Console.WriteLine("not prime");
        }
    }
}