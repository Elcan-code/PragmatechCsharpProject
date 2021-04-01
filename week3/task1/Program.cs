using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
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

            #region task 2
            string adsoyad1;
            int a1, b1, c1, d1, e1;
            Console.Write("Ad Soyad:");
            adsoyad1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Netice:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            d1 = Convert.ToInt32(Console.ReadLine());
            e1 = (a1 + b1 + c1 + d1) / 4;
            Console.WriteLine();
            Console.WriteLine("Ortalama:" + c);
            #endregion

            #region task 3
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

            #region while ile consoledan daxil edilen ededden geriye dogru loop

            int eded;
            Console.Write("Eded daxil et : ");
            eded = Convert.ToInt32(Console.ReadLine());
            while (eded > 0)
            {
                Console.WriteLine(eded);
                eded--;
            }
            #endregion

            #region while ile 0 ile 100 arasindaki tek ededlerin cemi
            int eded1 = 0, cem = 0;

            while (eded1 <= 100)
            {
                if (eded1 % 2 != 0) { cem += eded1; }


                eded1++;
            }
            Console.WriteLine(cem);
            #endregion

            #region while ile faktorialin hesablanmasi
            int number, hasil = 1;
            Console.Write("Eded daxil et : ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                hasil *= number;

                number--;
            }
            Console.WriteLine(hasil);
            #endregion

            #region  Mini login



            string Username, Password;
            string us = "admin";
            string ps = "adminpass";
            Console.Write("Username : ");
            Username = Console.ReadLine();
            Console.Write("Password : ");
            Password = Console.ReadLine();
            #region if
            if (Username == us && Password == ps)
            {
                Console.WriteLine("Ugurlu Emeliyyat");
            }
            else { Console.WriteLine("Emeliyyat Ugursuz Oldu"); }

            #endregion

            #region ternary
            var yoxla = Username == us && Password == ps ? "Ugurlu emeliyyat" : "Emeliyyat ugursuz oldu";
            Console.WriteLine(yoxla);
            #endregion
            #region Switch
            switch (Username)
            {
                case "admin" when Password == ps:
                    Console.WriteLine("Ugurlu Emeliyyat");
                    break;

            }
            #endregion

            #endregion

            #region role
            string input;
            Console.Write("Melumat Daxil Et : ");
            input = Console.ReadLine();
            if (input != "AA" || input != "BB" || input != "CC" || input != "MM" || input != "MH" || input != "UU")
            {
                Console.WriteLine("Daxil edilen selahiyyet dogru deyil");
            }
            else
            {
                switch (input)
                {
                    case "AA":
                        Console.WriteLine("Admin selahiyyetlerine sahibsiniz.");
                        break;
                    case "BB": goto case "AA";
                    case "CC": goto case "AA";
                    case "MM":
                        Console.WriteLine("Moderator selahiyyetlerine sahibsiniz.");
                        break;
                    case "MH":
                        Console.WriteLine("Muhasib selahiyyetlerine sahibsiniz.");
                        break;
                    case "UU":
                        Console.WriteLine("Standart istifadeci selahiyyetlerine sahibsiniz.");
                        break;

                }
            }
            #endregion


        }
    }
}
