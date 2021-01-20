using System;

namespace Campİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety = tip güvenliği C# ve Java da daha katıdır.
            //KategriEtiketi bir değer tutucudur yani takma isim nickname..
            string KategoriEtiketi = "KategoriEtiketi";
            int Sayi1 = 215434;
            bool SistemeGirişYapmişMi = true;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;
            if (DolarBugun>DolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (DolarBugun<DolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi");
            }
            Console.WriteLine(SistemeGirişYapmişMi);
            Console.WriteLine(Sayi1);
            Console.WriteLine(KategoriEtiketi);

            if (Sayi1 == 15)
            {
                Console.WriteLine("Sayi1 15 Değil");
            }
            else
            {
                Console.WriteLine("Sayi1 başka bir sayidir,Sittir Et!!");

            }
            Console.ReadLine();
        }
    }
}
