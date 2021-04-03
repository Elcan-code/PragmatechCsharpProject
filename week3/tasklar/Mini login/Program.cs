using System;

namespace Mini_login
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Mini login



            string Username, Password;
            string myusername = "admin";
            string mypassword = "adminpass";
            Console.Write("Username : ");
            Username = Console.ReadLine();
            Console.Write("Password : ");
            Password = Console.ReadLine();
            #region if
            if (Username == myusername && Password == mypassword)
            {
                Console.WriteLine("Ugurlu Emeliyyat");
            }
            else { Console.WriteLine("Emeliyyat Ugursuz Oldu"); }

            #endregion

            #region ternary
            var yoxla = Username == myusername && Password == mypassword ? "Ugurlu emeliyyat" : "Emeliyyat ugursuz oldu";
            Console.WriteLine(yoxla);
            #endregion
            #region Switch
            switch (Username)
            {
                case "admin" when Password == mypassword:
                    Console.WriteLine("Ugurlu Emeliyyat");
                    break;

            }
            #endregion

            #endregion
        }
    }
}
