using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpProjekatNrt36_17
{
    class Rezervacije
    {
        private int IDautomobila;
        private int IDkupca;
        private DateTime datum_od;
        private DateTime datum_do;
        private int cenaRezervacije;
        private int ukupnacena;

        public Rezervacije(int Idautomobila, int Idkupca, DateTime datum_od, DateTime datum_do, int cenaRezervacije)
        {
            IDautomobila1 = Idautomobila;
            IDkupca1 = Idkupca;
            this.Datum_od = datum_od;
            this.Datum_do = datum_do;
            this.CenaRezervacije = cenaRezervacije;
            this.Ukupnacena =cenaRezervacije;
        }

        public int IDautomobila1 { get => IDautomobila; set => IDautomobila = value; }
        public int IDkupca1 { get => IDkupca; set => IDkupca = value; }
        public DateTime Datum_od { get => datum_od; set => datum_od = value; }
        public DateTime Datum_do { get => datum_do; set => datum_do = value; }
        public int CenaRezervacije { get => cenaRezervacije; set => cenaRezervacije = value; }
        public int Ukupnacena { get => ukupnacena; set => ukupnacena = value; }

        public override string ToString()
        {
            return "ID Automobila"+" "+this.IDautomobila+" "+"ID Kupca"+" "+this.IDkupca+" "+ "Datum_od" + " " + this.datum_od.ToString("dd/MM/yyyy") + " " + "Datum_do" + " " + this.datum_do.ToString("dd/MM/yyyy") + " " + "Ukupna_cena" + " " + this.ukupnacena + " "+"dinara";
        }
    }
}
