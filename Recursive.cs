using System;

namespace cs101
{
    public class Recursive
    {
        public static void Metot()
        {
            Console.WriteLine(UsAlma(3,4));
            Console.WriteLine(RecursiveUsAlma(3,4));
        }

        public static int UsAlma(int sayi, int us)
        {
            int sonuc = sayi;

            for(int i = 1; i < us; i++)
            {
                sonuc *= sayi;
            }

            return sonuc;
        }

        public static int RecursiveUsAlma(int sayi, int us)
        {
            if(us < 2)
                return sayi;

            return RecursiveUsAlma(sayi,us-1) * sayi;
        }
    }

    
}