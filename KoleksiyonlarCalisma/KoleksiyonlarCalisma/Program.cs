using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayi = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            int AsalSayiToplam = 0;
            int ortalama, ortalama1 = 0;
            int AsalOlmayanToplam = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1 + ". Sayiyi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 1)
                {
                    Console.WriteLine("Tekrar giriniz.");
                    i -= i;
                }
                else if (sayi % 3 == 0 || sayi % 2 == 0)
                {
                    asalOlmayan.Add(sayi);
                }
                else
                {
                    asalSayi.Add(sayi);
                }

            }

            asalSayi.Sort();
            asalOlmayan.Sort();

            Console.WriteLine("***Sıralı Asal sayı Listesi***");
            foreach (var item in asalSayi)
                Console.WriteLine(item);

            for (int i = 0; i < asalSayi.Count; i++)
                AsalSayiToplam += Convert.ToInt32(asalSayi[i]);

            ortalama = AsalSayiToplam / asalOlmayan.Count;
            Console.WriteLine("Eleman Sayısı : " + asalSayi.Count + " Ortalaması : " + ortalama);
            //-----------------------------------------------------------------------------------------
            Console.WriteLine("***Sıralı Asal Olmayan sayı Listesi***");
            foreach (var item in asalOlmayan)
                Console.WriteLine(item);

            for (int i = 0; i < asalOlmayan.Count; i++)
                AsalOlmayanToplam += Convert.ToInt32(asalOlmayan[i]);

            ortalama1 = AsalOlmayanToplam / asalOlmayan.Count;
            Console.WriteLine("Eleman Sayısı : " + asalOlmayan.Count + " Ortalaması : " + ortalama1);

            Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Soru 2");
            int toplam = 0;
            int toplam1 = 0;

            ArrayList sayilar = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + ". Sayiyi giriniz : ");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(girilenSayi);
            }
            sayilar.Sort();
            Console.WriteLine("---------------------");

            foreach (var item in sayilar)
                Console.WriteLine(item);

            for (int i = 0; i < 3; i++)
            {
                toplam += Convert.ToInt32(sayilar[i]);
            }
            int ortalama = toplam / 3;
            Console.WriteLine("En küçük 3 sayının ortalaması " + ortalama);


            Console.WriteLine("----------------");
            sayilar.Reverse();
            foreach (var item in sayilar)
                Console.WriteLine(item);

            for (int i = 0; i < 3; i++)
            {
                toplam1 += Convert.ToInt32(sayilar[i]);
            }
            int ortalama1 = toplam1 / 3;
            Console.WriteLine("En büyük 3 sayının ortalaması " + ortalama1);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("İki ortalmanın toplamı : " + (ortalama1 + ortalama));
            Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Soru 3");
            Console.WriteLine("Lütfen bir cümle yazınız.");

            string metin = Console.ReadLine();
            string sesli = "aeıioöuü";

            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine(metin);
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane sesli harf vardır.", sayac);
            Console.ReadLine();
        }


    }
}
