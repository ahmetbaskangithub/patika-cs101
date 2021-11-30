using System;

namespace cs101
{
    public class ConsoleProgramlama
    {
        public static void ConsoleProgramlamaMetot()
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);

            Console.ReadKey();

        }
    }
}
