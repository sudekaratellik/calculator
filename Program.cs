using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    internal class Program
    {
        static double Topla(double sayi1,double sayi2)
        {
            return sayi1 + sayi2;
        }

        static double Cıkar(double sayi1,double sayi2)
        {
            return sayi1 - sayi2;
        }

        static double Carp(double sayi1,double sayi2)
        {
            return sayi1 * sayi2;
        }

        static double Bol(double sayi1 ,double sayi2)
        {
            if (2 != 0)
            {
                return sayi1 / sayi2;
            }

            else
            {
                Console.WriteLine("bir sayi 0 a bolunemez");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" birinci sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("yapmak istediğiniz işlemi seçiniz:");

            Console.WriteLine("1-toplama");
            Console.WriteLine("2-çıkarma");
            Console.WriteLine("3-çarpma");
            Console.WriteLine("4-bölme");

            int secim = Convert.ToInt32(Console.ReadLine());
            double sonuc = 0;

            switch (secim)
            {
                case 1:
                    sonuc = Topla(sayi1, sayi2);

                    break;

                case 2:
                    sonuc = Cıkar(sayi1, sayi2);
                    break;

                case 3:
                    sonuc = Carp(sayi1, sayi2);
                    break;

                case 4:
                    sonuc = Bol(sayi1, sayi2);
                    break;
                default:
                    Console.WriteLine("gecersiz islem yaptınız:");
                    return;
                    
               

            }
            Console.WriteLine("sonuç:" + sonuc);
            Console.ReadKey();







        }

    
    }
}
