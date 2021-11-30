using System;

namespace cs101
{
    public class Operatorler
    {
        public static void OperatorlerMetot()
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 2;

            y = y + 2;
            y += 2;
            y /= 3;

            x *= 2;

            //x ++;
            int z = x++;
            Console.WriteLine(z);

            // mantıksal operatörler
            // || , && , !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            // ilşkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = a < b; // true
            sonuc = a > b; // false
            sonuc = a <= b; // true
            sonuc = a >= b; // false
            sonuc = a == b; // false
            sonuc = a != b; // true

            // aritmetik operatörler
            // +,-,/,*

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            sonuc1 = sayi1 / sayi2; // 2
            sonuc1 = sayi1 * sayi2; // 50
            sonuc1 = sayi1 + sayi2; // 15
            sonuc1 = sayi1 - sayi2; // 5

            // sayi1 = 10;
            sonuc1 = sayi1 ++; // sonuc1 = 10, sayi1 = 11
            sonuc1 = sayi1 --; // sonuc1 = 11, sayi1 = 10
            sonuc1 = ++ sayi1; // sonuc1 = 11, sayi1 = 11
            sonuc1 = -- sayi1; // sonuc1 = 10, sayi1 = 10

            sonuc1 = sayi1 % 7; // 3
        }
    }
}
