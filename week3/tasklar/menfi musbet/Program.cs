using System;

namespace menfi_musbet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region menfi musbet
            decimal in1;
            Console.Write("Eded daxil et : ");
            in1 = Convert.ToDecimal(Console.ReadLine());
            #region if
            if (in1 >= 0) { Console.WriteLine("Musbetdir"); }
            else { Console.WriteLine("Menfidir"); }
            #endregion
            #region ternary
            var vz = in1 < 0 ? "Menfidir" : "Musbetdir";
            Console.WriteLine(vz);
            #endregion
            #endregion
        }
    }
}
