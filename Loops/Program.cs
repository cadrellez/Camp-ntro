using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = { "JS", "Java", "Python", "Sql", "Tsql", "Ossurma Sanatı Kursu" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);  // Bir dizi içinde ki değişkenleri yazdırmak için kursları i olarak dolaşırsın.
            }
            Console.WriteLine("********");
            foreach (var kurs in kurslar) // Dizi Temelli yapıları tek tek dönmeye-İtere etmeye yarar.FOREACH SADECE DİZİLERE UYGULANIR.
            {
                Console.WriteLine(kurs);
            }

            
            Console.WriteLine("Sayfa Sonu");
            Console.ReadLine();
         
    }

    }
}
