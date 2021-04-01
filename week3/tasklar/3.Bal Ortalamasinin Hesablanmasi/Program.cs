using System;

namespace _3.Bal_Ortalamasinin_Hesablanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.Bal Ortalamasinin Hesablanmasi
            string adsoyad;
            int a2, b2, c2, d2, e;
            Console.Write("Ad Soyad:");
            adsoyad = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Netice:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            d2 = Convert.ToInt32(Console.ReadLine());
            e = (a2 + b2 + c2 + d2) / 4;

            if (e > 100 || e < 0) { Console.WriteLine("Neticeleri Dogru Daxil Edin"); }
            else
            {
                Console.WriteLine(adsoyad);
                Console.WriteLine();
                Console.WriteLine(e);
                Console.WriteLine();
                Console.Write("Semestr Yekunu : ");
                if (e < 45)
                {
                    Console.WriteLine("qeyri - kafi Kece bilmediz");
                }
                else if (e >= 45 && e < 70)
                {
                    Console.WriteLine("Meqbul");
                }
                else if (e >= 70 && e < 90)
                {
                    Console.WriteLine("Yaxsi");
                }
                else if (e >= 90 && e <= 100)
                {
                    Console.WriteLine("Ela");
                }
            }

            #endregion
        }
    }
}
