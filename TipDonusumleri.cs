using System;

namespace cs101
{
    public class TipDonusumleri
    {
        public static void TipDonusumleriMetot()
        {
            // implicit conversion
            Console.WriteLine("***** implicit conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " + d);

            long h = d;
            Console.WriteLine("h : " + h);

            float f = h;
            Console.WriteLine("f : " + f);

            string s = "Ahmet";
            char c1 = 'a';
            object o = s + c1 + d;
            Console.WriteLine("o : " + o);

            
            
            // explicit conversion
            Console.WriteLine("***** explicit conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            float f1 = 10.3f;
            byte v = (byte)f1;
            Console.WriteLine("v : " + v);


            // *** ToString Metodu *** //
            Console.WriteLine("***** ToString Metodu *****");
            
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz);


            // *** System.Convert *** //
            Console.WriteLine("***** System.Convert Sınıfı *****");
            
            string s1 = "10", s2 = "20";
            int sayi1 , sayi2,toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam : " + toplam);

            // *** Parse *** //
            Console.WriteLine("***** Parse Metodu (string ifade alır) *****");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string s1 = "10";
            string s2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(s1);
            double1 = Double.Parse(s2);
            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);
        }
    }
}
