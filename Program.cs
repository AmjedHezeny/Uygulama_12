using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
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

                Console.WriteLine("(1).İki Sayının Toplamı ve Ortalaması veya Sayıların Toplamı ve Ortalaması yapılır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(2).Kullanıcıdan alınan sayıların çift ise toplama, tek ise çıkarma işlemi yapılarak \r\nhesaplanan sonuçların toplandığı yapılır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(3).kullanıcının pozitif bir sayı girmesini isteyen ve girilen değerin pozitif \r\nolup olmadığını sürekli olarak kontrol eder.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(4).kullanıcının yaşını girmesini isteyen ve girilen yaş değerine göre 18 yaşından \r\nbüyük olanları sayarak askere giden kişi sayısını hesapılır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(5).kullanıcının belirli bir kullanıcı adı ve şifre kombinasyonunu girmesini \r\nbekleyen bir giriş sistemi yapılır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(6).kullanıcının 1 ile 7 arasında bir sayı girmesi istenerek, girilen sayının \r\nhangi günü temsil ettiğini eşleştiren bir programı.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.WriteLine("(7).bilgisayarın rastgele bir sayı oluşturduğu ve kullanıcının bu sayıyı \r\ntahmin etmeye çalıştığı bir tahmin oyununu yapılır.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        double toplam = 0;
                        int adetSayac = 0;

                        Console.Write("1.Sayıyı Giriniz : ");
                        int sayi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("2.Sayıyı Giriniz : ");
                        int sayi2 = int.Parse(Console.ReadLine());

                        if (sayi1 == sayi2)
                        {
                            Console.WriteLine("Sayılar Eşittir");
                        }
                        else
                        {
                            if (sayi1 <= sayi2)
                            {
                                while (sayi1 <= sayi2)
                                {
                                    toplam += sayi1;
                                    adetSayac++;
                                    sayi1++;
                                }

                            }
                            else
                            {
                                while (sayi2 <= sayi1)
                                {
                                    toplam += sayi2;
                                    sayi2++;
                                    adetSayac++;
                                }

                            }
                            Console.WriteLine("Sayıların Toplamı : " + toplam);
                            double ort = (double)toplam / adetSayac;
                            Console.WriteLine("Sayıların Ortalaması : " + ort);
                        }

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
                        int sayi, toplam = 0;

                            Console.Write("Sayı Giriniz : ");
                            sayi = int.Parse(Console.ReadLine());
                            if (sayi % 2 == 0)
                            {
                                toplam += sayi;
                                Console.WriteLine("Sonuç : " + toplam);
                            }
                            else
                            {
                                toplam -= sayi;
                                Console.WriteLine("Sonuç : " + toplam);
                            }
                        

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
                        int kullaniciSayi;
                        do
                        {
                            Console.Write("Pozitif Bir Sayı Giriniz : ");
                            kullaniciSayi = int.Parse(Console.ReadLine());

                        } while (kullaniciSayi <= 0);
                        Console.Clear();
                        Console.WriteLine("Girdiğiniz sayı pozitif bir sayıdır : " + kullaniciSayi);

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
                        int sayac = 0, askereGiden = 0, yas;

                        do
                        {
                            Console.Write("Yaş Giriniz : ");
                            yas = int.Parse(Console.ReadLine());

                            if (yas >= 18)
                            {
                                askereGiden++;
                            }
                            sayac++;
                        } while (sayac < 10);
                        Console.WriteLine("Askere giden kişi sayısı : " + askereGiden);

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


                ////***********************************************************************//

                else if (soru == "5")
                {
                  
                    do
                    {

                        string userName = "ahmet", password = "123456";

                        string kullaniciAdi, sifre;

                        do
                        {
                            Console.Write("Kullanıcı Adı : ");
                            kullaniciAdi = Console.ReadLine();

                            Console.Write("Şifre : ");
                            sifre = Console.ReadLine();

                            if (kullaniciAdi != userName || sifre != password)
                            {
                                Console.WriteLine("Yanlış kullanıcı adı veya şifre");
                            }

                        } while (kullaniciAdi != userName || sifre != password);

                        Console.Clear();
                        Console.WriteLine("Giriş İşlemi Başarılı");

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

                else if (soru == "6")
                {
                    do
                    {
                        int sayi;


                            Console.Write("1 ile 7 arasında bir sayı girin : ");
                            sayi = int.Parse(Console.ReadLine());
                            switch (sayi)
                            {
                                case 1:
                                    Console.WriteLine("Pazartesi");
                                    break;
                                case 2:
                                    Console.WriteLine("Salı");
                                    break;
                                case 3:
                                    Console.WriteLine("Çarşamba");
                                    break;
                                case 4:
                                    Console.WriteLine("Perşembe");
                                    break;
                                case 5:
                                    Console.WriteLine("Cuma");
                                    break;
                                case 6:
                                    Console.WriteLine("Cumartesi");
                                    break;
                                case 7:
                                    Console.WriteLine("Pazar");
                                    break;
                                case 0:
                                    Console.WriteLine("Çıkış yapılıyor");
                                    break;

                                default:
                                    Console.WriteLine("Geçersiz Bir Sayı Girdiniz ");
                                    break;

                            }
                  


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

                else if (soru == "7")
                {

                    do
                    {
                        Random rastgeleSayi = new Random();
                        int randomOlusturulanSayi = rastgeleSayi.Next(0, 100);

                        int kullaniciTahmin;
                        int tahmin = 1;
                        do
                        {
                            Console.Write("Bir Tahmin Giriniz : ");
                            kullaniciTahmin = int.Parse(Console.ReadLine());

                            if (kullaniciTahmin > randomOlusturulanSayi)
                            {
                                Console.WriteLine("Daha küçük bir sayı giriniz ");
                            }
                            else if (kullaniciTahmin < randomOlusturulanSayi)
                            {
                                Console.WriteLine("Daha büyük bir sayı giriniz ");
                            }
                            else
                            {
                                Console.WriteLine("Tebrikler Doğru Bildiniz ");
                            }
                            tahmin++;

                        } while (kullaniciTahmin != randomOlusturulanSayi && tahmin <= 10);
                        Console.Clear();
                        if (tahmin >= 10)
                        {
                            Console.WriteLine("Hakkınız Doldu");
                        }

                        Console.Write("Devam etmek istiyor musunuz? (Evet için 'e' veya 'E', Hayır için 'h' veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();
                }

            } while (soru != "0");

            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}
