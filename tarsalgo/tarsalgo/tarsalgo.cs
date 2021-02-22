using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace tarsalgo
{
    class tarsalgo
    {
        static List<Szinhaztarsalgo> Tarsalgo = new List<Szinhaztarsalgo>();
        static void Main(string[] args)
        {
            Console.WriteLine("1.feladat:ajto.txt beolvasása");
            Beolvas("ajto.txt");
            Console.WriteLine("\n2.feladat:");
            int elso = Tarsalgo.First().Id;
            int utolso = Tarsalgo.Last().Id;
            Console.WriteLine($"\tAz első belépő{elso}");
            Console.WriteLine($"\tAz utolsó kilépő:{utolso}");
            Console.WriteLine("\n3.feladat:");
            Dictionary<int, int> Gyakorisag = new Dictionary<int, int>();
            StreamWriter iras = new StreamWriter("athaladas.txt", false, Encoding.Default);
            foreach (var taitem in Tarsalgo)
            {
                if (!Gyakorisag.ContainsKey(taitem.Id))
                {
                    Gyakorisag.Add(taitem.Id, 0);
                }
            }
            foreach (var item in Tarsalgo)
            {
                if (Gyakorisag.ContainsKey(item.Id))
                {
                    Gyakorisag[item.Id]++;
                }
            }
            foreach (var item in Gyakorisag)
            {
                iras.WriteLine($"{item.Key} {item.Value}");
            }
            iras.Close();
            Console.WriteLine("\n4.feladat:");
            Console.WriteLine("A végén a társalgóban voltak:");
            for (int i = 0; i < Tarsalgo.Count; i++)
            {
                if (Tarsalgo[i].Ora>9)
                {
                    Console.Write($"{Tarsalgo[i].Id} ");
                }
            }
            Console.WriteLine("\n5.feladat:");
            Console.Write("Kérek egy időpontot:");
            DateTime idopont = DateTime.Parse(Console.ReadLine());
            int bedb = 0;
            for (int i = 0; i < Tarsalgo.Count; i++)
            {
                if (Tarsalgo[i].Id>0)
                {
                    bedb++;
                    Console.WriteLine($"{Tarsalgo[i].Ora}:{Tarsalgo[i].Perc}-kor voltak a legtöbben a társalgóban.");
                }
            }
            Console.Write("\n6.feladat:Kérek egy azonosítót:");
            int azon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n7.feladat:");
            bool Szerepel = false;
            for (int i = 0; i < Tarsalgo.Count; i++)
            {
                if (azon==Tarsalgo[i].id)
                {
                    if (Tarsalgo[i].Irany=="be")
                    {
                        Szerepel = true;
                        Console.Write($"{Tarsalgo[i].Ora}:{Tarsalgo[i].Perc} -");
                        break;
                    }
                    else
                    {
                        Console.Write($"{Tarsalgo[i].Ora}:{Tarsalgo[i].Perc} - ");
                    }
                   
                }
            }
            if (!Szerepel)
            {
                Console.WriteLine("A társalgóban nem volt ilyen azonosító!");
            }
            Console.WriteLine("\n8.feladat:");
            Console.WriteLine("\nProgam Vége!");
            Console.ReadLine();
        }
        static void Beolvas(string filenev)
        {
            using (StreamReader sr=new StreamReader(filenev))
            {
                while (!sr.EndOfStream)
                {
                    Szinhaztarsalgo szin = new Szinhaztarsalgo(sr.ReadLine());
                    Tarsalgo.Add(szin);
                }
            }
        }
    }
}
