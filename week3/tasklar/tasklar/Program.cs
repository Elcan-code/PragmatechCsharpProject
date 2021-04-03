using System;

namespace tasklar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            #region 2.Bal Ortalamasinin Hesablanmasi
            string namesurname;
            int score1, score2, score3, score4, average;
            Console.Write("Ad Soyad:");
            namesurname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Netice:");
            score1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score4 = Convert.ToInt32(Console.ReadLine());
            average = (score1 + score2 + score3 + score4) / 4;
            Console.WriteLine();
            Console.WriteLine("Ortalama:" + average);
            #endregion
  
        }
    }
}
