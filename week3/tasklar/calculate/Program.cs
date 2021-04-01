using System;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region calculate 
            decimal ed1, ed2;
            char emeliyyat;
            Console.Write("Eded1 : "); ed1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" Toplama (+) , Cixma (-) , Vurma (x) , Bolme (/)  Daxil edin");
            Console.Write("Emeliyyat : "); emeliyyat = Convert.ToChar(Console.ReadLine());
            Console.Write("Eded2 : "); ed2 = Convert.ToDecimal(Console.ReadLine());
            #region normal switch
            switch (emeliyyat)
            {
                case '+':
                    Console.WriteLine("Netice : " + (ed1 + ed2));
                    break;
                case '-':
                    Console.WriteLine("Netice : " + (ed1 - ed2));
                    break;
                case 'x':
                    Console.WriteLine("Netice : " + (ed1 * ed2));
                    break;
                case '/':
                    Console.WriteLine("Netice : " + (ed1 / ed2));
                    break;
            }
            #endregion
            #region exp switch

            var eml = emeliyyat switch
            {
                '+' => ed1 + ed2,
                '-' => ed1 - ed2,
                '/' => ed1 / ed2,
                'x' => ed1 * ed2,
            };
            Console.WriteLine("Netice : " + eml);
            #endregion

            #endregion
        }
    }
}
