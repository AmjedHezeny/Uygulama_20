using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_20
{
    internal class Metodlar
    {
        ////************************** soru 1 Metodlar *********************************************//

        public string Ad;
        public string Soyad;
        public int N1;
        public int N2;

        ////************************** soru 2 Metodlar *********************************************//

        public string marka, model, plaka;
        public int km, yil;

        ////************************** soru 4 Metodlar *********************************************//

        public static int IntAl(string metin)
        {
            int sayi = 0;
            bool hata = true;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    hata = false;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }
        public static void Topla(int s1, int s2)
        {
            Console.WriteLine("Sayıların Toplamı = " + (s1 + s2));         
        }
        public static void FarkiniAl(int s1, int s2)
        {
            Console.WriteLine("Sayıların Farkı = " + (s1 - s2));        
        }
        public static void CarpimiHesapla(int s1, int s2)
        {
            Console.WriteLine("Sayıların Çarpımı = " + (s1 * s2));       
        }
        public static void BolmeIslemi(int s1, int s2)
        {
            Console.WriteLine("Sayıların Bölümü = " + ((double)s1 / s2));        
        }
    }
}