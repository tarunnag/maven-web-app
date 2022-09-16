using System;
class array
{
    public static void Main()
    {
        Console.WriteLine("enter the length of array:");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] c = new int[a];
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("enter the the integer:");
            c[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        Array.Sort(c);
        Console.WriteLine(c[c.Length - 2]);
    }
}