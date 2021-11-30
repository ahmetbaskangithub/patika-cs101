using System;

namespace cs101
{
    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string [] dizi = param.Split(" ");
            return string.Join("",dizi);
            //return param.Replace(" ","");
        }

        public static string ToUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string ToLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int [] param)
        {
            Array.Sort(param);

            return param;
        }

        public static void WriteArray(this int [] param)
        {
            foreach (var item in param)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static bool IsEvenNumber(this int param)
        {
            if(param % 2 == 0)
                return true;
            else
                return false;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1); // start index - length
        }
    }
}