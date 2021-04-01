using System;

namespace Week3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = (a + b + c) / 3;
            var netice = d >= 45 ? "Beli" : "Xeyr";
            Console.WriteLine(netice);
        }
    }
}
