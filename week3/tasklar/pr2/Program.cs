using System;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Bal Ortalamasinin Hesablanmasi
            int a, b, c, d;
            Console.Write("Netice:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            c = Convert.ToInt32(Console.ReadLine());
            d = (a + b + c) / 3;
            var netice = d >= 45 ? "Beli" : "Xeyr";
            Console.WriteLine(netice);
            #endregion
        }
    }
}
