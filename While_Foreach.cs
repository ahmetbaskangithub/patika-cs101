using System;

namespace cs101
{
    public class While_Foreach
    {
        public static void While_ForeachMetot()
        {
            // while
            // 1 ile konsoldan girilen sayı kadar olan sayıların ortalaması
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine("Ortalama : " + toplam / sayi);

            // a - z arasındaki tüm harfleri yazdırma

            char harf = 'a';
            while (harf <= 'z')
            {
                Console.Write(harf);
                harf ++;
            }

            Console.WriteLine("***** Foreach *****");

            string [] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}