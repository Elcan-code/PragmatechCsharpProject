using System;

namespace role
{
    class Program
    {
        static void Main(string[] args)
        {

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
