using System;

namespace week5task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Havada bulut dimplom isini unut
            /*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             */

           
            Console.WriteLine("-----------------------");
            Console.Write("Ad Soyad Daxil edin : ");
            string fullname = Console.ReadLine();
            string[] point = new string[3];
            string[] writevalue = new string[3] { "1-ci imtahan nəticənizi daxil edin : ", "2-ci imtahan nəticənizi daxil edin : ", "3-ci imtahan nəticənizi daxil edin : " };
            int i = 0;
            while (true)
            {
                if (i > 2) { break; }

                Console.Write(writevalue[i]);
                point[i] = Console.ReadLine();
                if (Student.Check(point[i]) == 1) { i++; }
                else
                if (Student.Check(point[i]) == 2) { point[i] = "51"; i++; }
                else { Student.Error(); }
            }
            int average = Student.Average(point[0], point[1], point[2]);
            bool result = Student.Diplomisi(average);
            Student.Print(point[0], point[1], point[2], average, result, fullname); 
            
            #endregion
        }
    }
}
