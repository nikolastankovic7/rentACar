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
    public partial class Automobili1 : Form
    {
        OpenFileDialog openfile = new OpenFileDialog();
        string line = "";
        private int rednibroj=5;
        private int idbr;
        string putanja = "automobilizaiznajmljivanje.txt";
        FileStream fs;
        Automobil kola;
        StreamReader sr;
        Administrator frm;
        public Automobili1()
        {
            InitializeComponent();
        }
        //konstruktor kada se forma poziva iz neke druge
        public Automobili1(Administrator frm) : this()
        {
            this.frm = frm;
        }
        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {
            idbr = rednibroj++;
          

           


            if (txtMarkaAutomobila.Text.Trim().Length != 0 && txtModelAutomobila.Text.Trim().Length != 0 && txtGodisteAutomobila.Text.Trim().Length != 0 &&
               txtKubikazaAutomobila.Text.Trim().Length != 0 && txtPogonAutomobila.Text.Trim().Length != 0 && txtKaroserija.Text.Trim().Length != 0 && txtVrstaGoriva.Text.Trim().Length != 0 && txtBrojVrata.Text.Trim().Length != 0)
            {
                int broj;
                bool uspesno = int.TryParse(txtGodisteAutomobila.Text, out broj) && int.TryParse(txtKubikazaAutomobila.Text, out broj) && int.TryParse(txtBrojVrata.Text, out broj);
                if (uspesno == true)
                {
                    if (File.Exists(putanja))
                    {
                        fs = new FileStream(putanja, FileMode.Append, FileAccess.Write);
                    }
                    else
                    {
                        fs = new FileStream(putanja, FileMode.Create, FileAccess.Write);
                    }
                    kola = new Automobil(idbr, txtMarkaAutomobila.Text, txtModelAutomobila.Text, int.Parse(txtGodisteAutomobila.Text), int.Parse(txtKubikazaAutomobila.Text), txtPogonAutomobila.Text, txtVrstaMenjaca.Text, txtKaroserija.Text, txtVrstaGoriva.Text, int.Parse(txtBrojVrata.Text));
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(kola);
                    lstPrikazAutomobila.Items.Add(kola);
                    txtMarkaAutomobila.Clear();
                    txtModelAutomobila.Clear();
                    txtGodisteAutomobila.Clear();
                    txtPogonAutomobila.Clear();
                    txtVrstaMenjaca.Clear();
                    txtKubikazaAutomobila.Clear();
                    txtKaroserija.Clear();
                    txtVrstaGoriva.Clear();
                    txtBrojVrata.Clear();
                    MessageBox.Show("Automobil je uspešno dodat!");
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    fs.Dispose();
                }
                else
                {
                    MessageBox.Show("Neispravan unos");
                }
            }
            else
            {
                MessageBox.Show("Neispravan unos");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstPrikazAutomobila.SelectedIndex != -1)
            {
                string rec = lstPrikazAutomobila.SelectedItem.ToString();
                string[] elementistringa = rec.Split(',');
                if (txtMarkaAutomobila.Text.Trim().Length != 0 && txtModelAutomobila.Text.Trim().Length != 0 && txtGodisteAutomobila.Text.Trim().Length != 0 &&
               txtKubikazaAutomobila.Text.Trim().Length != 0 && txtPogonAutomobila.Text.Trim().Length != 0 && txtKaroserija.Text.Trim().Length != 0 && txtVrstaGoriva.Text.Trim().Length != 0 && txtBrojVrata.Text.Trim().Length != 0)
                {
                    int god = int.Parse(txtGodisteAutomobila.Text);
                    int kubikaza = int.Parse(txtKubikazaAutomobila.Text);
                    int brojvrata = int.Parse(txtBrojVrata.Text);
                    int broj;


                    bool uspesno = int.TryParse(txtGodisteAutomobila.Text, out broj) && int.TryParse(txtKubikazaAutomobila.Text, out broj) && int.TryParse(txtBrojVrata.Text, out broj);
                    if (uspesno)
                    {
                        kola = new Automobil(idbr, txtMarkaAutomobila.Text, txtModelAutomobila.Text, int.Parse(txtGodisteAutomobila.Text), int.Parse(txtKubikazaAutomobila.Text), txtPogonAutomobila.Text, txtVrstaMenjaca.Text, txtKaroserija.Text, txtVrstaGoriva.Text, int.Parse(txtBrojVrata.Text));
                        List<string> lista = File.ReadAllLines(putanja).ToList();
                        lista.Insert(lstPrikazAutomobila.SelectedIndex, kola.ToString());
                        lista.RemoveAt(lstPrikazAutomobila.SelectedIndex + 1);

                        File.WriteAllLines((putanja), lista.ToArray());
                        lstPrikazAutomobila.Items.Insert(lstPrikazAutomobila.SelectedIndex, kola);
                        lstPrikazAutomobila.Items.RemoveAt(lstPrikazAutomobila.SelectedIndex);
                        txtMarkaAutomobila.Clear();
                        txtModelAutomobila.Clear();
                        txtGodisteAutomobila.Clear();
                        txtPogonAutomobila.Clear();
                        txtVrstaMenjaca.Clear();
                        txtKubikazaAutomobila.Clear();
                        txtKaroserija.Clear();
                        txtVrstaGoriva.Clear();
                        txtBrojVrata.Clear();
                        MessageBox.Show("Uspešno ste izmenili podatke o automobilu");
                    }
                    else
                        MessageBox.Show("Neuspesno");
                }
                else
                    MessageBox.Show("Neuspesno");

            }
            else
                MessageBox.Show("Niste izabrali automobil");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstPrikazAutomobila.SelectedIndex != -1)
            {
                List<string> lista = File.ReadAllLines(putanja).ToList();
                lista.RemoveAt(lstPrikazAutomobila.SelectedIndex);
                File.WriteAllLines((putanja), lista.ToArray());
                string[] linije = File.ReadAllLines(putanja);
                lstPrikazAutomobila.Items.RemoveAt(lstPrikazAutomobila.SelectedIndex);
                MessageBox.Show("Automobil je obrisan");
            }
            else
                MessageBox.Show("Niste izabrali automobil");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Automobili1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(putanja);
           lstPrikazAutomobila.Items.AddRange(lines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //nacin za povratak na prethodnu
            this.Hide();
            frm.Show();
        }
    }
    }

