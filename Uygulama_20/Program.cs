using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_20
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string soru, cevap;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(1).Kullanıcıdan Öğrenci Bilgileri Alan, Not Ortalaması Hesaplayan Öğrenci Sınıfı Oluşturma.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Kullanıcıdan İki Farklı Araba Bilgisi Alan ve Bu Bilgileri Ekrana Yazdıran Araba Sınıfı Oluşturma.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).Kullanıcıdan 2 sayı alalım, try-catch ile kontrol edip toplayalım. Hatalı giriş olursa tekrar isteyelim.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).Kullanıcıdan 2 sayı al, 4 işlem menüsü göster, seçilen işlemi uygula.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");


                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        Metodlar o = new Metodlar();

                        Console.Write("Öğrencinin Adını Giriniz : ");
                        o.Ad = Console.ReadLine();
                        Console.Write("Öğrencinin Soyadını Giriniz : ");
                        o.Soyad = Console.ReadLine();
                        Console.Write("Öğrencinin 1.Sınav Notunu Giriniz : ");
                        o.N1 = int.Parse(Console.ReadLine());
                        Console.Write("Öğrencinin 2.Sınav Notunu Giriniz : ");
                        o.N2 = int.Parse(Console.ReadLine());

                        double ortalama = (double)(o.N1 + o.N2) / 2;

                        Console.WriteLine("Öğrencinin Adı : " + o.Ad);
                        Console.WriteLine("Öğrencinin Soyadı : " + o.Soyad);
                        Console.WriteLine("Öğrencinin 1.Sınav Notu : " + o.N1);
                        Console.WriteLine("Öğrencinin 2.Sınav Notu : " + o.N2);
                        Console.WriteLine("Öğrencinin Sınav Ortalaması : " + ortalama);

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                //***********************************************************************//

                else if (soru == "2")
                {
                    do
                    {
                        Metodlar araba1 = new Metodlar();
                        Console.Write("Arabanın Markasını Giriniz : ");
                        araba1.marka = Console.ReadLine();
                        Console.Write("Arabanın Modelini Giriniz : ");
                        araba1.model = Console.ReadLine();
                        Console.Write("Arabanın Plakasını Giriniz : ");
                        araba1.plaka = Console.ReadLine();
                        Console.Write("Arabanın Km sini Giriniz : ");
                        araba1.km = int.Parse(Console.ReadLine());
                        Console.Write("Arabanın Yılını Giriniz : ");
                        araba1.yil = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Metodlar araba2 = new Metodlar();
                        Console.Write("Arabanın Markasını Giriniz : ");
                        araba2.marka = Console.ReadLine();
                        Console.Write("Arabanın Modelini Giriniz : ");
                        araba2.model = Console.ReadLine();
                        Console.Write("Arabanın Plakasını Giriniz : ");
                        araba2.plaka = Console.ReadLine();
                        Console.Write("Arabanın Km sini Giriniz : ");
                        araba2.km = int.Parse(Console.ReadLine());
                        Console.Write("Arabanın Yılını Giriniz : ");
                        araba2.yil = int.Parse(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("------ 1.Arabanın Bilgileri -----");
                        Console.WriteLine();
                        Console.WriteLine("Arabanın Markası = " + araba1.marka);
                        Console.WriteLine("Arabanın Modeli =" + araba1.model);
                        Console.WriteLine("Arabanın Plakası = " + araba1.plaka);
                        Console.WriteLine("Arabanın Km si = " + araba1.km);
                        Console.WriteLine("Arabanın Yılı = " + araba1.yil);

                        Console.WriteLine();
                        Console.WriteLine("------- 2.Arabanın Bilgileri ------");
                        Console.WriteLine();
                        Console.WriteLine("Arabanın Markası = " + araba2.marka);
                        Console.WriteLine("Arabanın Modeli =" + araba2.model);
                        Console.WriteLine("Arabanın Plakası = " + araba2.plaka);
                        Console.WriteLine("Arabanın Km si = " + araba2.km);
                        Console.WriteLine("Arabanın Yılı = " + araba2.yil);


                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                ////***********************************************************************//

                else if (soru == "3")
                {
                    do
                    {
                        bool hata = true;

                        do
                        {
                            Console.Clear();
                            try
                            {
                                Console.Write("1.Sayıyı Giriniz : ");
                                int sayi = int.Parse(Console.ReadLine());
                                Console.Write("2.Sayıyı Giriniz : ");
                                int sayi2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Sayıların Toplamı = " + (sayi + sayi2));
                                hata = false;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                hata = true;
                            }

                        } while (hata);

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();

                }
                ////***********************************************************************//


                else if (soru == "4")
                {
                    do
                    {
                        int secim = 0;
                        Console.Clear();
                        int sayi1 = Metodlar.IntAl("1.Sayıyı Giriniz : ");
                        int sayi2 = Metodlar.IntAl("2.Sayıyı Giriniz : ");
                        Console.Clear();
                        Console.WriteLine("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme");
                        secim = Metodlar.IntAl("İşlem Türünü Giriniz : ");


                        switch (secim)
                        {
                            case 1:
                                Metodlar.Topla(sayi1, sayi2);
                                break;
                            case 2:
                                Metodlar.FarkiniAl(sayi1, sayi2);
                                break;
                            case 3:
                                Metodlar.CarpimiHesapla(sayi1, sayi2);
                                break;
                            case 4:
                                Metodlar.BolmeIslemi(sayi1, sayi2);
                                break;
                            default:
                                Console.WriteLine("Yanlış Bir İşlem Türü Girdiniz ");
                                break;
                        }
                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }

                        else
                        {
                            Console.Clear();
                        }

                    } while (true);
                    Console.Clear();
                }

            } while (soru != "0");

            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}
