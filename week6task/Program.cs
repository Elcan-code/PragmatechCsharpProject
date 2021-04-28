using System;

namespace week6task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region rectangle
            /*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class memeber-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilnlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */

            Rectangle rectangle = new Rectangle();
            Console.Write("Duzbucaqlinin enini daxil edin : ");
            rectangle.En = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duzbucaqlinin uzunlugunu daxil edin : ");
            rectangle.Uzunluq = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duzbucaqlinin Sahesi: ");
            Console.WriteLine(Rectangle.Sahe(rectangle.En, rectangle.Uzunluq));
            #endregion
            #region teacher
            /*
             *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
             *  datalarini saxlasin.
             *  Id: sadece oxuna biler auto yaradilacaq.
             *  Vezife: daxil edilmeyibse nulldursa Teacher deye set edilsin.
             *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
             */
            Console.Write("Hal hazirki tarix : ");
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine();
            Muellim muellim = new Muellim();
            Console.Write("Adinizi daxil edin : ");
            muellim.Ad = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin : ");
            muellim.Soyad = Console.ReadLine();
            Console.Write("Vezife daxil edin : ");
            muellim.Vezife = Console.ReadLine();
            Console.Write("Dogum tarxinzi daxil edin : ");
            muellim.DogumTarixi = Convert.ToDateTime((Console.ReadLine() + " 11:00:00 AM"));
            Console.Write("Is yeri : ");
            muellim.Yer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("___________________________________");
            Console.WriteLine();
            Console.WriteLine(muellim.Id);
            Console.WriteLine(muellim.Ad);
            Console.WriteLine(muellim.Soyad);
            Console.WriteLine(muellim.Vezife);
            Console.WriteLine(muellim.DogumTarixi);
            Console.WriteLine(muellim.Yer);
            TimeSpan span = DateTime.Now.Subtract(muellim.BaslamaTarixi);
            if (Convert.ToInt32(span.Days) >= 1) { Console.WriteLine(muellim.BaslamaTarixi); }
            else { Console.WriteLine("Yasiniz is ucun yeterli deyil"); }

            #endregion
        }
    }
}
