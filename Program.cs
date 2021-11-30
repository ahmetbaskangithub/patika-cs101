using System;

namespace cs101
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConsoleProgramlama.ConsoleProgramlamaMetot();
            // Degiskenler.DegiskenlerMetot();
            // Operatorler.OperatorlerMetot();
            // TipDonusumleri.TipDonusumleriMetot();
            // ExceptionHandling.ExceptionHandlingMetot();
            // IfElse.IfElseMetot();
            // SwitchCase.SwitchCaseMetot();
            // ForLoop.ForLoopMetot();
            // While_Foreach.While_ForeachMetot();
            // Diziler.DizilerMetot();
            // ArraySınıfMetotları.ArraySınıfMetot();
            // Metotlar.Metot();
            // MetotOverloading.Metot();
            // Recursive.Metot();
            string sentence = "Hello World";

            Console.WriteLine(sentence.CheckSpaces());
            Console.WriteLine(sentence.RemoveWhiteSpaces());
            Console.WriteLine(sentence.ToUpperCase());
            Console.WriteLine(sentence.ToLowerCase());

            int [] dizi = {9,3,6,2,1,5,0};

            dizi.SortArray();

            dizi.WriteArray();

            int num1 = 5, num2 = 6;

            Console.WriteLine(num1.IsEvenNumber());
            Console.WriteLine(num2.IsEvenNumber());

            Console.WriteLine(sentence.GetFirstCharacter());
        }
    }
}
