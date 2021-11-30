using System;
namespace cs101
{
    public class MetotOverloading
    {
        public static void Metot()
        {
            // out
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);

            if(sonuc)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Topla(2,3, out int toplamSonucu);

            Console.WriteLine(toplamSonucu);

            // metot overloading

            // Metot imzası:
            //metotAdı + parametresayisi + parametre tipleri
            
            // Geri dönüş tipi metot imzasına dahil değildir.
            // Yani sadece geri dönüş tipini değiştirerek bir metodu aşırı yükleyemeyiz. Derleyici hata verecektir.

            int intDeger = 999;
            string stringDeger = "hello ";
            string stringDeger2 = "world";

            EkranaYazdir(intDeger);
            EkranaYazdir(stringDeger);
            EkranaYazdir(stringDeger,stringDeger2);
        }
        
        public static void EkranaYazdir(int deger)
        {
            Console.WriteLine(deger);
        }

        public static void EkranaYazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public static void EkranaYazdir(string deger1,string deger2)
        {
            Console.WriteLine(deger1 + deger2);
        }
        public static void Topla (int a, int b,  out int toplam)
        {
            toplam = a+b;
        }
    }
}