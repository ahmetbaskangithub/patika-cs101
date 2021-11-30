using System;

namespace cs101
{
    public class ExceptionHandling
    {
        public static void ExceptionHandlingMetot()
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
            }

            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }

            try
            {
                //int i = int.Parse(null);
                //int a = int.Parse("text");
                int a = int.Parse("-243223424323423432");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok büyük veya çok küçük bir değer girildi.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
