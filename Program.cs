using System;

namespace degiskenler
{
class Program
{
    private static void Main(string[] args)
    {
        int deger;
        deger = 2;

        byte b= 5;     //1 byte
        sbyte sb = 5;  //1 byte 

        short s = 5;    //2 byte
        ushort us = 5;  //2 byte
        Int16 i16 =2;   //2 byte
        int i = 2;      //4 byte
        Int32 i32 = 2;  //4 byte
        Int64 i64 = 2;  //8 byte
        uint ui = 2;    //4 byte
        long l = 2;     //8 byte
        ulong ul=2;     //8 byte

        //reel sayılar
        float f = 5;    //4 byte
        double d = 5;   //8 byte
        decimal de = 5; //16 byte

        char c ='2';       //2 byte
        string str ="ece"; //sınırsız

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        //string ifadeler


        string str1 = string.Empty;
        str1 = "Ece Karakus";
        string ad = "Ece";
        string soyad = "Karakus";
        string tamisim = ad + " " + soyad;

        //integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        //boolean

        bool b01 = 10<2;  //10 2'den küçük olmadığı için bu ifade false gelecektir.

        //Değişken Dönüşümleri

        string str20 = "20";
        int int20 = 20;
        string yenideger = str20 + int20.ToString();
        Console.WriteLine(yenideger); //çıktısı 2020 integer değeri de string değerine çevirip 2 değeri yan yana ekledi.

        int int21 = int20+Convert.ToInt32(str20);
         Console.WriteLine(int21); //çıktısı 40, string değeri integer değere çevirip matematiksel toplamını aldı.

         int int22 = int20 + int.Parse(str20);//Çıktısı 40 - parse string'den dönüşüm için kullanılır.

         //Datetime

         string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
         Console.WriteLine(dt1);

         string hour = DateTime.Now.ToString("HH:mm");
         Console.WriteLine(hour);

         string dt2= DateTime.Now.ToString("dd/MM/yyyy");
         Console.WriteLine(dt2);

         



    }
}
}