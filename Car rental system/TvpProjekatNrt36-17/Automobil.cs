using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpProjekatNrt36_17
{ 
    public class Automobil
    {

        private int iD;
        private string marka;
        private string model;
        private int godiste;
        private int kubikaza;
        private string pogon;
        private string vrsta_menjaca;
        private string karoserija;
        private string gorivo;
        private int broj_vrata;
        
        public Automobil()
        {

        }
        public Automobil(int iD)
        {
            this.iD = iD;
            
        }
        public Automobil(int iD,string marka)
        {
            this.iD = iD;
            this.marka = marka;

        }

        public Automobil(int iD, string marka, string model, int godiste, int kubikaza, string pogon, string vrsta_menjaca, string karoserija, string gorivo, int broj_vrata)
        {
            this.iD = iD;
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
            this.kubikaza = kubikaza;
            this.pogon = pogon;
            this.vrsta_menjaca = vrsta_menjaca;
            this.karoserija = karoserija;
            this.gorivo = gorivo;
            this.broj_vrata = broj_vrata;
        }

        public void setIdAutomobila(int id)
        {
            this.iD = id;
        }
        public int getIdAutomobila()
        {
            return iD;
        }
        public void SetMarka(string marka)
        {
            this.marka = marka;
        }
        public string getMarka()
        {
            return this.marka;
        }
       public void setModel(string model)
        {
            this.model = model;
        }
        public string getModel()
        {
            return model;
        }
        public void setGodiste(int godiste)
        {
            this.godiste = godiste;
        }
        public int getGodiste()
        {
            return this.godiste;
        }
        public void setKubikaza(int kubikaza)
        {
            this.kubikaza = kubikaza;
        }
        public int getKubikaza()
        {
            return this.kubikaza;
        }
        public void setPogon(string pogon)
        {
            this.pogon = pogon;
        }
        public string getPogon()
        {
            return this.pogon;
        }
        public void setVrstaMenjaca (string vrsta_menjaca)
        {
            this.vrsta_menjaca = vrsta_menjaca;
        }
        public string getVrstaMenjaca()
        {
            return this.vrsta_menjaca;
        }
        public void setKaroserija(string karoserija)
        {
            this.karoserija = karoserija;
        }
        public string getKaroserija()
        {
            return this.karoserija;
        }
        public void setGorivo(string gorivo)
        {
            this.gorivo = gorivo;
        }
        public string getGorivo()
        {
            return this.gorivo;
        }
        public void setBrojVrata(int broj_vrata)
        {
           this.broj_vrata = broj_vrata;
        }
        public int getBrojVrata()
        {
            return this.broj_vrata;
        }

        public override string ToString()
        {
            return iD + " " + marka + " " + model + " " + godiste + " " + kubikaza + " " + pogon + " " + vrsta_menjaca + " " + karoserija + " " + gorivo + " " + broj_vrata;
        }
    }
}
