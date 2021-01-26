using System;

namespace DictionaryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> teams = new MyDictionary<string, string>();
            teams.Add("Gs", "Galatasaray");
            teams.Add("Ts", "Trabzon");
            teams.Add("Bjk", "Besiktas");
            teams.Add("Psv", "Eindhoven");
            teams.Add("OL", "Olympiqe Lyon");
            teams.Add("Bvb", "Borussia Dortmund");
            for (int i = 0; i < teams.key.Length; i++)
            {
                Console.WriteLine(teams.key[i] + ":" + teams.value[i]);
            }

        }

    }
}
