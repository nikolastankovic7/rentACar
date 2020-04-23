using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvpProjekatNrt36_17
{
    public partial class Kupackor : Form
    {
        Ponuda ponuda;
        private static int brojac;
        private int idbr;
        string putanja;
        FileStream fs;
        Control control;
        Kupac kupac;
        public Kupackor()
        {
            putanja = "kupci.txt";
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        { Random rand = new Random();
            idbr = rand.Next(4, 11);
            
            if (txtImeKupca.Text.Trim().Length != 0 && txtPrezimeKupca.Text.Trim().Length != 0 && txtJmbgKupca.Text.Trim().Length != 0 && txtTelefon.Text.Trim().Length != 0)
            {
                string telefon = Convert.ToInt64(txtTelefon.Text).ToString("0##-###-###");
                string telefon1 = Convert.ToInt64(txtTelefon.Text).ToString("0##-###-####");
                if (File.Exists(putanja))
                {
                    fs = new FileStream(putanja, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(putanja, FileMode.Create, FileAccess.Write);
                }
                if (txtTelefon.TextLength == 9)
                {
                    kupac = new Kupac(idbr, txtImeKupca.Text, txtPrezimeKupca.Text, txtJmbgKupca.Text, dateTimePicker1.Value, telefon);
                }
                else if (txtTelefon.Text.Length == 10)
                {
                    kupac = new Kupac(idbr, txtImeKupca.Text, txtPrezimeKupca.Text, txtJmbgKupca.Text, dateTimePicker1.Value, telefon1);
                }
                else
                {
                    MessageBox.Show("Neispravan broj mobilnog telefona");
                }
           
                 
               
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(kupac);
                txtImeKupca.Clear();
                txtJmbgKupca.Clear();
                txtPrezimeKupca.Clear();
                txtTelefon.Clear();
                MessageBox.Show("Uspešno ste postali naš kupac!, prebacujemo vas na stranicu sa rezervacijama");
                Form2 kupi = new Form2();
                kupi.Show();
                this.Hide();
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Korisnici1 korisnik = new Korisnici1();
            this.Close();
            korisnik.Show();
        }
    }
}
