using System;

namespace _3.Bal_Ortalamasinin_Hesablanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.Bal Ortalamasinin Hesablanmasi
            string namesurname;
            int score1, score2, score3, score4, total;
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
            total= (score1 + score2 + score3 + score4) / 4;

            if (total> 100 || total < 0) { Console.WriteLine("Neticeleri Dogru Daxil Edin"); }
            else
            {
                Console.WriteLine(namesurname);
                Console.WriteLine();
                Console.WriteLine(total);
                Console.WriteLine();
                Console.Write("Semestr Yekunu : ");
                if (total< 45)
                {
                    Console.WriteLine("qeyri - kafi Kece bilmediz");
                }
                else if (total>= 45 && total< 70)
                {
                    Console.WriteLine("Meqbul");
                }
                else if (total>= 70 && total< 90)
                {
                    Console.WriteLine("Yaxsi");
                }
                else if (total>= 90 && total<= 100)
                {
                    Console.WriteLine("Ela");
                }
            }

            #endregion
        }
    }
}
