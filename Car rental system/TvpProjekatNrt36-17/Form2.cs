using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TvpProjekatNrt36_17
{

    public partial class Form2 : Form
    {

        FileStream fs;
         string putanja;
        string putanja2;
        string putanja3;
        string ime;
        Rezervacije rezervacija;
        int pomocna;
        Kupac kupac;
        int brojdana;
        string selektovano1;
        string selektovano2;

        List<string> ponude = new List<string>();
        public Form2()
        {
            putanja = "kupci.txt";
            putanja2 = "ponuda.txt";
            putanja3 = "rezervacija.txt";
            InitializeComponent();


        }

        private void btnDostupniTerminiAutomobila_Click(object sender, EventArgs e)
        {
            string provera = "0";
            string selektovano = (string)cmbModel.SelectedItem;
            string[] linije = File.ReadAllLines(putanja2);
            if (linije[10].Contains(provera) && selektovano == "Accord")
            {
                listBox1.Items.Add(linije[10]);
            }
            string provera1 = "1";
            string[] proveravaj = File.ReadAllLines(putanja2);
            if (linije[0].Contains(provera1) && selektovano == "Civic")
            {
                listBox1.Items.Add(linije[0]);
            }
            string provera2 = "2";
            string[] proveravaj1 = File.ReadAllLines(putanja2);
            if (linije[1].Contains(provera1) && selektovano == "Impreza")
            {
                listBox1.Items.Add(linije[1]);
            }
            string provera3 = "3";
            string[] proveravaj2 = File.ReadAllLines(putanja2);
            if (linije[2].Contains(provera1) && selektovano == "Supra")
            {
                listBox1.Items.Add(linije[2]);
            }
            string provera4 = "4";
            string[] proveravaj4 = File.ReadAllLines(putanja2);
            if (linije[3].Contains(provera1) && selektovano == "TT")
            {
                listBox1.Items.Add(linije[3]);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnici1 korisnik = new Korisnici1();
            this.Close();
            korisnik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selektovano1 = cmbMarka.Text;
            string selektovano2 = cmbModel.Text;
            DateTime pocetak = dtdPreuzimanje.Value;
            DateTime kraj = dtdVraćanje.Value;
            TimeSpan proteklovreme = kraj - pocetak;
            brojdana = proteklovreme.Days;
            txtBrojDana.Text = brojdana.ToString();

            //prvi automobil//
            if (selektovano1 == "Honda" && selektovano2 == "Accord")
            {
                try
                {
                    dtdPreuzimanje.MinDate = new DateTime(2019, 6, 23);
                    dtdVraćanje.MaxDate = new DateTime(2019, 6, 30);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }



                int racun = brojdana * 3000;
                txtCena.Text = racun.ToString();
            }
            //drugi automobil//
            if (selektovano1 == "Honda" && selektovano2 == "Civic")
            {

                try
                {
                    dtdPreuzimanje.MinDate = new DateTime(2019, 2, 7);
                    dtdVraćanje.MaxDate = new DateTime(2019, 2, 14);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }
                int racun = brojdana * 3600;
                txtCena.Text = racun.ToString();
            }
            //treci automobil//
            if (selektovano1 == "Subaru" && selektovano2 == "Impreza")
            {
                try
                {
                   
                    dtdPreuzimanje.MinDate = new DateTime(2019, 3, 8);
                    dtdVraćanje.MaxDate = new DateTime(2019, 3, 15);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }

                int racun = brojdana * 5000;
                txtCena.Text = racun.ToString();
            }
            //cetvrti automobil//
            if (selektovano1 == "Toyota" && selektovano2 == "Supra")
            {
                try
                {

                    dtdPreuzimanje.MinDate = new DateTime(2019, 4, 11);
                    dtdVraćanje.MaxDate = new DateTime(2019, 4, 18);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }
                int racun = brojdana * 4000;
                txtCena.Text = racun.ToString();

            }
            //peti automobil//
            if (selektovano1 == "Audi" && selektovano2 == "TT")
            {
               
                dtdPreuzimanje.MinDate = new DateTime(2019, 5, 18);
                dtdPreuzimanje.MaxDate = new DateTime(2019, 5, 25);
                int racun = brojdana * 4500;
                txtCena.Text = racun.ToString();
            }


        }

        private void dtdPreuzimanje_ValueChanged(object sender, EventArgs e)
        {
            string selektovano1 = cmbMarka.Text;
            string selektovano2 = cmbModel.Text;
            if (selektovano1 == "Honda" && selektovano2 == "Accord")
            {
                try
                {
                    dtdPreuzimanje.MinDate = new DateTime(2019, 6, 23);
                    dtdVraćanje.MaxDate = new DateTime(2019, 6, 30);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }
                if (selektovano1 == "Honda" && selektovano2 == "Civic")
                {

                    try
                    {
                        dtdPreuzimanje.MinDate = new DateTime(2019, 2, 7);
                        dtdVraćanje.MaxDate = new DateTime(2019, 2, 14);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Datum vam je u pogresnom opsegu");
                    }

                }
            }
            if (selektovano1 == "Subaru" && selektovano2 == "Impreza")
            {
                try
                {
                    
                    dtdPreuzimanje.MinDate = new DateTime(2019, 3, 8);
                    dtdVraćanje.MaxDate = new DateTime(2019, 3, 15);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }
            }
            if (selektovano1 == "Toyota" && selektovano2 == "Supra")
            {
                try
                {

                    dtdPreuzimanje.MinDate = new DateTime(2019, 4, 11);
                    dtdVraćanje.MaxDate = new DateTime(2019, 4, 18);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }
            }
            if (selektovano1 == "Audi" && selektovano2 == "TT")
            {
                try
                {
                   
                    dtdPreuzimanje.MinDate = new DateTime(2019, 5, 18);
                    dtdPreuzimanje.MaxDate = new DateTime(2019, 5, 25);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datum vam je u pogresnom opsegu");
                }

            }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        { selektovano1 = cmbMarka.Text;
            selektovano2 = cmbModel.Text;
            if (File.Exists(putanja3))
            {
                fs = new FileStream(putanja3, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(putanja3, FileMode.Create, FileAccess.Write);
            }
            if (selektovano1 == "Honda" && selektovano2 == "Accord")
            {
                rezervacija = new Rezervacije(0, 4, dtdPreuzimanje.Value, dtdVraćanje.Value, int.Parse(txtCena.Text));
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(rezervacija);
                MessageBox.Show("Vaša rezervacija je uspešna, hvala na ukazanom poverenju!");
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
                this.Close();
            }
           
            if (selektovano1 == "Honda" && selektovano2 == "Civic")
            {
                rezervacija = new Rezervacije(1, 5, dtdPreuzimanje.Value, dtdVraćanje.Value, int.Parse(txtCena.Text));
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(rezervacija);
                MessageBox.Show("Vaša rezervacija je uspešna, hvala na ukazanom poverenju!");
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
                this.Close();

            }
         
            if (selektovano1 == "Subaru" && selektovano2 == "Impreza")
            {
                rezervacija = new Rezervacije(2, 9, dtdPreuzimanje.Value, dtdVraćanje.Value, int.Parse(txtCena.Text));
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(rezervacija);
                MessageBox.Show("Vaša rezervacija je uspešna, hvala na ukazanom poverenju!");
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
                this.Close();

            }
          
            if (selektovano1 == "Toyota" && selektovano2 == "Supra")
            {
                rezervacija = new Rezervacije(3, 7, dtdPreuzimanje.Value, dtdVraćanje.Value, int.Parse(txtCena.Text));
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(rezervacija);
                MessageBox.Show("Vaša rezervacija je uspešna, hvala na ukazanom poverenju!");
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
                this.Close();

            }
         
            if (selektovano1 == "Audi" && selektovano2 == "TT")
            {
                rezervacija = new Rezervacije(4, 5, dtdPreuzimanje.Value, dtdVraćanje.Value, int.Parse(txtCena.Text));
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(rezervacija);
                MessageBox.Show("Vaša rezervacija je uspešna, hvala na ukazanom poverenju!");
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
                this.Close();
            }
           
           
        }
    }
}







 