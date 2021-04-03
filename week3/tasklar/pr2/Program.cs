using System;

namespace pr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Bal Ortalamasinin Hesablanmasi
            int score1, score2, score3,average;
            Console.Write("Netice:");
            score1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score3 = Convert.ToInt32(Console.ReadLine());
            average = (score1 + score2 + score3) / 3;
            var result = average >= 45 ? "YES" : "NO";
            Console.WriteLine(result);
            #endregion
        }
    }
}
