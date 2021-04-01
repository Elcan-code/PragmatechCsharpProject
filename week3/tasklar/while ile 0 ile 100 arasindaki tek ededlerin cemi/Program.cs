using System;

namespace while_ile_0_ile_100_arasindaki_tek_ededlerin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while ile 0 ile 100 arasindaki tek ededlerin cemi
            int eded1 = 0, cem = 0;

            while (eded1 <= 100)
            {
                if (eded1 % 2 != 0) { cem += eded1; }


                eded1++;
            }
            Console.WriteLine(cem);
            #endregion
        }
    }
}
