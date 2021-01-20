using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;   // Değer tiperde birbirine atama olur ve atama olduktan sonra birbiri arasında bağlantı kopar.yani verilerden biri daha sonradan dğişse bile birbirini bağlamaz.
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //Console.ReadLine();

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] {100,200,300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 800;               //Referans Tiplerde Aynı adres kullanılır ve ancak adreste bir değişim olursa her iki veri de değişir. Aralarında bağlantı daima vardır.
            Console.WriteLine(sayilar1[0]);
            Console.ReadLine();
        }
    }
}
