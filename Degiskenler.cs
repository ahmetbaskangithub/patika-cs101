using System;

namespace cs101
{
    public class Degiskenler
    {
        public static void DegiskenlerMetot()
        {
            // int deger = 2;
            // string degisken = null;
            // string Degisken = null;
            // byte b = 5; // 1 byte
            // sbyte c = 3; // 1 byte

            // short s = 5; // 2 byte
            // ushort us = 5; // 2 byte

            // Int16 i16 = 2 ; // 2 byte
            // int i = 2; // 4 byte
            // Int32 i32 = 2; // 4 byte;
            // Int64 i64 = 2; // 8 byte

            // uint ui = 2; // 4 byte

            // long l = 4; // 8 byte
            // ulong ul = 4; // 8 byte

            // float f = 2.5f; // 4 byte
            // double d = 2.5; // 8 byte
            // decimal de = 2.5m; // 16 byte

            // char ch = 'a' ; // 2 byte
            // string str = "string"; // sınırsız

            // bool b1 = true;
            // bool b2 = false;

            DateTime dt1 = DateTime.Now;

            object o1 = "x";
            object o2 = 'x';
            object o3 = 4;
            object o4 = 4.3;

            // string

            //string str1 = null;
            string str1 = string.Empty;
            str1 = "Hello world";
            string str2 = "Hi";
            string str3 = str1 + " " + str2;

            // integer

            int int1 = 5;
            int int2 = 8;
            int int3 = int1 * int2;

            // boolean

            // bool bool1 = 10 < 2;

            // değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeğer = str20 + int20.ToString(); // 2020

            int int21 = int20 + Convert.ToInt32(str20); // 40

            int int22 = int20 + int.Parse(str20); // 40

            // Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm");
        }
    }
}
