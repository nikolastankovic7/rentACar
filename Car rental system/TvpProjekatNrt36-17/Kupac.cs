using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpProjekatNrt36_17
{
    class Kupac
    {
        private int IDkupca;
        private string ime;
        private string prezime;
        private string jmbg;
        private DateTime datumrodjenja;
        private string telefon;

        public Kupac(int IDkupca, string ime, string prezime, string jmbg,  DateTime datumrodjenja, string telefon)
        {
            this.IDkupca = IDkupca;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumrodjenja = datumrodjenja;
            this.telefon = telefon;

        }
        public int getIDkupca()
        {
            return this.IDkupca;
        }
        public void setIDkupca(int IDkupca)
        {
            this.IDkupca = IDkupca;
        }
        public string getIme()
        {
            return this.ime;
        }
        public void setImeKupca(string ime)
        {
            this.ime = ime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public string getJMBG()
        {
            return this.jmbg;
        }
        public void setJMBG(string jmbg)
        {
            this.jmbg = jmbg;
        }
        public DateTime getDatumRodjenja()
        {
            return this.datumrodjenja;
        }
        public void setDatumRodjenja(DateTime datumrodjenja)
        {
            this.datumrodjenja = datumrodjenja;
        }
        public string getTelefon()
        {
            return this.telefon;
        }
        public void setTelefon(string telefon)
        {
            this.telefon = telefon;
        }

        public override string ToString()
        {
            return IDkupca + " " + ime + " " + prezime + " " + jmbg + " " + datumrodjenja + " " + telefon + " ";
        }
    }
}
