using System;

namespace cs101
{
    public class ForLoop
    {
        public static void ForLoopMetot()
        {
            // ekrandan girilen sayıya kadar olan tek sayılar yazdır
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i < sayac; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            
            // 1-1000 arasındaki tek ve çift sayıların toplamı
            int tekToplam = 0, ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }

            Console.WriteLine("Tek Toplam : " + tekToplam);
            Console.WriteLine("Cift Toplam : " + ciftToplam);

            // break , continue

            for (int i = 1; i < 10; i++)
            {
                // if(i == 4)
                //     break; // dongüyü sonlandırır

                if(i == 4)
                    continue; // mevcut iterasyonu sonlandırır
                
                Console.WriteLine(i);
            }
        }
    }
}
