using System;

namespace cs101
{
    public class Diziler
    {
        public static void DizilerMetot()
        {
            // dizi tanımlama

            string [] renkler = new string[5];
            string [] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int [] dizi;
            dizi = new int[5];

            // dizilere değer atama ve erişim

            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // döngülerle dizi kullanımı
            // klavyeden girilen n sayının ortalaması
            Console.Write("Dizinin boyutunu giriniz: ");
            int boyut = int.Parse(Console.ReadLine());
            
            int [] sayiDizisi = new int[boyut];
            
            for (int i = 0; i < boyut; i++)
            {
                Console.Write("Dizinin {0}. elemanını giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama: {0}", toplam / boyut);
        }
    }
}