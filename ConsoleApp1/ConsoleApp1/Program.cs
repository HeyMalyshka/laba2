using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite A");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("vvedite B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cho sdelat: *, /, +, -");
            char c = Convert.ToChar(Console.ReadLine());
            
            int s;
            if (c == '+') s = a + b;
            else if (c == '-') s = a - b;
            else if (c == '*') s = a * b;
            else if (c == '/') s = a / b;
        }
    }
}
