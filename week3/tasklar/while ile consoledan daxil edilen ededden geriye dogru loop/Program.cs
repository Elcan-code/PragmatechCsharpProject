using System;

namespace while_ile_consoledan_daxil_edilen_ededden_geriye_dogru_loop
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
