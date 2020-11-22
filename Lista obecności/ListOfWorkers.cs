using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;

namespace Lista_obecności
{
    [Serializable()]
    public class ListOfWorkers
    {
        public List<string> Imie = new List<string>();
        public List<string> Nazwisko = new List<string>();
        public List<string> Dzial = new List<string>();
        public List<int> Id = new List<int>();
        int iCurrentRow = 0;
        [NonSerialized()] IEnumerable<string> sortDzial;
        string sSection = "";
        public string SSection { set { sSection = value; } }

        //czysczenie list
        public void ListOfWorkersClear()
        {
            this.Imie.Clear();
            this.Nazwisko.Clear();
            this.Dzial.Clear();
            this.Id.Clear();
        }

        //wczytanie z pliku
        public void ListOfWorkersAdd(String Imie, String Nazwisko, String Dzial)
        {
            this.Imie.Add(Imie.ToUpper());
            this.Nazwisko.Add(Nazwisko.ToUpper());
            this.Dzial.Add(Dzial.ToUpper());
            this.Id.Add(Id.Count);
        }
        
    }
}

