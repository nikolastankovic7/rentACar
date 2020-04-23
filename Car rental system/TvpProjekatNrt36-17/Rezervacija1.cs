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
    public partial class Rezervacija1 : Form
    {
        FileStream fs;
        int pomocna;
        string putanja = "rezervacija.txt";
        Rezervacije rezervacija;
        Administrator admin;
        public Rezervacija1()
        {
            InitializeComponent();
        }
        public Rezervacija1(Administrator admin):this()
        {
            this.admin = admin;
        }

        private void btnDodajPonudu_Click(object sender, EventArgs e)
        {
            double broj;
            int brojac = 0;
            int id = int.Parse(cmbIDBR.Text);
            int id2 = int.Parse(cmbKupca.Text);
            if (txtCenaPoDanu.Text.Trim().Length != 0)
            {
                if (File.Exists(putanja))
                {
                    fs = new FileStream(putanja, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(putanja, FileMode.Create, FileAccess.Write);
                }
                bool uspesno = int.TryParse(txtCenaPoDanu.Text, out pomocna);
                if (uspesno)
                {
                    rezervacija = new Rezervacije(id, id2, dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(txtCenaPoDanu.Text));
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(rezervacija);
                    lstPrikazRezervacija.Items.Add(rezervacija);
                    txtCenaPoDanu.Clear();
                    MessageBox.Show("Rezervacija je dodata!");
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    fs.Dispose();
                }
                else
                    MessageBox.Show("Neuspešno");
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            double broj;
            int brojac = 0;
            int id = int.Parse(cmbIDBR.Text);
            int id2 = int.Parse(cmbKupca.Text);
            if (lstPrikazRezervacija.SelectedIndex != -1)
            {
                if (txtCenaPoDanu.Text.Trim().Length != 0)
                {
                    double cena = double.Parse(txtCenaPoDanu.Text);
                    bool uspesno = double.TryParse(txtCenaPoDanu.Text, out broj);
                    if (uspesno)
                    {
                        rezervacija = new Rezervacije(id, id2, dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(txtCenaPoDanu.Text));
                        List<string> lista = File.ReadAllLines(putanja).ToList();
                        lista.Insert(lstPrikazRezervacija.SelectedIndex, rezervacija.ToString());
                        lista.RemoveAt(lstPrikazRezervacija.SelectedIndex + 1);
                        File.WriteAllLines((putanja), lista.ToArray());
                        lstPrikazRezervacija.Items.Insert(lstPrikazRezervacija.SelectedIndex, rezervacija);
                        lstPrikazRezervacija.Items.RemoveAt(lstPrikazRezervacija.SelectedIndex);
                        MessageBox.Show("Rezervacija je izmenjena");
                    }
                }
            }
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (lstPrikazRezervacija.SelectedIndex != -1)
            {
                List<string> lista = File.ReadAllLines(putanja).ToList();
                lista.RemoveAt(lstPrikazRezervacija.SelectedIndex);
                File.WriteAllLines((putanja), lista.ToArray());
                lstPrikazRezervacija.Items.RemoveAt(lstPrikazRezervacija.SelectedIndex);
                MessageBox.Show("Rezervacija je obrisana");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            this.Close();
            admin.Show();
        }

        private void Rezervacija1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(putanja);
            lstPrikazRezervacija.Items.AddRange(lines);
        }
    }
}
