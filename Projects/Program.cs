using System;
class atm
{
    public static void Main()
    {
        string username = "tarun";
        string password = "tarun123";
        int c = 0;
        int d = 0;
        do
        {
            Console.WriteLine("enter the username:");
            String a = Console.ReadLine();
            Console.WriteLine("enter the password:");
            string b = Console.ReadLine();
            if (a == username && b == password)
            {
                c = 3;
                d = 1;
            }
            else
            {
                c++;
                d = 0;
            }
        } while (c != 3 && d != 1);
        if (c == 3 && d == 1)
        {
            Console.WriteLine("you can access");
        }
        else
        {

            Console.WriteLine("you cannot access;");
        }
    }
}