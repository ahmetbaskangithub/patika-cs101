using System;
namespace cs101
{
    public class Metotlar
    {
        public static void Metot()
        {
            int a = 7, b = 8;
            int sonuc = Topla(a,b);
            EkranaYazdir(sonuc.ToString()); // 15

            int sonuc2 = ArttirVeTopla(ref a,ref b);
            EkranaYazdir(sonuc2.ToString()); // 17

            int sonuc3 = Topla(a,b);
            EkranaYazdir(sonuc3.ToString()); // 17
        }
        public static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

        public static void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public static int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 ++;
            deger2 ++;

            return deger1 + deger2;
        }
    }
}