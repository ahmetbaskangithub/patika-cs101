using System;

namespace cs101
{
    public class ArraySınıfMetotları
    {
        public static void ArraySınıfMetot()
        {
            // sort
            int [] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};

            Console.WriteLine("***** Sırasız Dizi *****");
            
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sıralı Dizi *****");
            
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // clear
            Console.WriteLine("***** Array Clear *****");
            
            Array.Clear(sayiDizisi,2,3); // dizi,index,length

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // reverse
            Console.WriteLine("***** Array Reverse *****");
            
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // indexOf
            Console.WriteLine("***** indexOf *****");

            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            // resize
            Console.WriteLine("***** Resize *****");
            
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}