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
    public partial class Ponuda1 : Form
    { FileStream fs;
        string putanja;
        Ponuda ponuda;
        Administrator admin;
        public Ponuda1()
        {
            InitializeComponent();
            putanja = "ponuda.txt";
        }
        public Ponuda1(Administrator admin) : this()
        {
            this.admin = admin;
        }

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        { double broj;
            int brojac = 0;
            int id = int.Parse(cmbIDBR.Text);
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
                bool uspesno = double.TryParse(txtCenaPoDanu.Text, out broj);
                if (uspesno)
                {
                    ponuda = new Ponuda(id, dateTimePicker1.Value, dateTimePicker2.Value, double.Parse(txtCenaPoDanu.Text));
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(ponuda);
                    lstPrikazPonuda.Items.Add(ponuda);
                    txtCenaPoDanu.Clear();
                    MessageBox.Show("Ponuda je dodata");
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    fs.Dispose();
                }
                else
                    MessageBox.Show("Niste popunili sva polja");
            }
            else
                MessageBox.Show("Niste dobro popunili sve podatke!");
        }

        private void btnIzmeniAuto_Click(object sender, EventArgs e)
        {
            double broj;
            int brojac = 0;
            int id = int.Parse(cmbIDBR.Text);
            if (lstPrikazPonuda.SelectedIndex!=-1)
            {
                if (txtCenaPoDanu.Text.Trim().Length!=0)
                {
                    double cena = double.Parse(txtCenaPoDanu.Text);
                    bool uspesno = double.TryParse(txtCenaPoDanu.Text, out broj);
                    if(uspesno)
                    {
                        ponuda = new Ponuda(id, dateTimePicker1.Value, dateTimePicker2.Value, double.Parse(txtCenaPoDanu.Text));
                        List<string> lista = File.ReadAllLines(putanja).ToList();
                        lista.Insert(lstPrikazPonuda.SelectedIndex, ponuda.ToString());
                        lista.RemoveAt(lstPrikazPonuda.SelectedIndex + 1);
                        File.WriteAllLines((putanja), lista.ToArray());
                        lstPrikazPonuda.Items.Insert(lstPrikazPonuda.SelectedIndex, ponuda);
                        lstPrikazPonuda.Items.RemoveAt(lstPrikazPonuda.SelectedIndex);
                        MessageBox.Show("Ponuda je izmenjena");
                    }
                }
              
            }
        }

        private void btnObrišiPonudu_Click(object sender, EventArgs e)
        {
            if(lstPrikazPonuda.SelectedIndex != -1)
            {
                List<string> lista = File.ReadAllLines(putanja).ToList();
                lista.RemoveAt(lstPrikazPonuda.SelectedIndex);
                File.WriteAllLines((putanja), lista.ToArray());
                lstPrikazPonuda.Items.RemoveAt(lstPrikazPonuda.SelectedIndex);
                MessageBox.Show("Ponuda je izbrisana");
            }
        }

        private void Ponuda1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(putanja);
            lstPrikazPonuda.Items.AddRange(lines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            this.Close();
            admin.Show();
        }
    }
}
