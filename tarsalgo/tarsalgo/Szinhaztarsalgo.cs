using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    class Szinhaztarsalgo
    {
        public int ora;
        public int perc;
        public int id;
        public string irany;
        public int db;

        public int Ora { get => ora; set => ora = value; }
        public int Perc { get => perc; set => perc = value; }
        public int Id { get => id; set => id = value; }
        public string Irany { get => irany; set => irany = value; }

        public Szinhaztarsalgo(int ora, int perc, int id, string irany)
        {
            Ora = ora;
            Perc = perc;
            Id = id;
            Irany = irany;
        }
        public Szinhaztarsalgo(string sor)
        {
            string[] adatok = sor.Split(' ');
            db = 0;
            Ora = int.Parse(adatok[0]);
            Perc = int.Parse(adatok[1]);
            Id = int.Parse(adatok[2]);
            Irany = adatok[0];
            db++;
        }
    }
}
