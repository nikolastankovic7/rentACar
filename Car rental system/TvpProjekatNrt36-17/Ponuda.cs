using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvpProjekatNrt36_17
{
    class Ponuda 
    {
             private int iD;
        private DateTime datum_od;
        private DateTime datum_do;
        private double cena_po_danu;

        public Ponuda(int iD, DateTime datum_od, DateTime datum_do, double cena_po_danu)
        {
            this.ID = iD;
            this.Datum_od = datum_od;
            this.Datum_do = datum_do;
            this.Cena_po_danu = cena_po_danu;
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime Datum_od { get => datum_od; set => datum_od = value; }
        public DateTime Datum_do { get => datum_do; set => datum_do = value; }
        public double Cena_po_danu { get => cena_po_danu; set => cena_po_danu = value; }
       
        public override string ToString()
        {
            return   ID + " "  + datum_od  + " "+  datum_do + " "  + cena_po_danu;
        }
       

    }

        
    }


