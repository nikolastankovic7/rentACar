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
    public partial class Kupac1 : Form
    {
        private static int brojac;
        private int idbr;
        string putanja;
        FileStream fs;
        Control control;
        Kupac kupac;
        Administrator frm;
        public Kupac1()
        {
            InitializeComponent();
            putanja = "kupci.txt";
        }
        public Kupac1(Administrator frm) : this()
        {
            this.frm = frm;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            idbr = brojac++;
            if(txtImeKupca.Text.Trim().Length != 0 && txtPrezimeKupca.Text.Trim().Length!=0 && txtJmbgKupca.Text.Trim().Length != 0 && txtTelefon.Text.Trim().Length != 0)
            {
                string telefon = Convert.ToInt64(txtTelefon.Text).ToString("0##-###-###");
                string telefon1 =Convert.ToInt64(txtTelefon.Text).ToString("0##-###-####");
                if (File.Exists(putanja))
                    {
                    fs = new FileStream(putanja, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(putanja, FileMode.Create, FileAccess.Write);
                }
                if(txtTelefon.TextLength==9)
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
                lstListaKupaca.Items.Add(kupac);
                txtImeKupca.Clear();
                txtJmbgKupca.Clear();
                txtPrezimeKupca.Clear();
                txtTelefon.Clear();
                /* foreach(Control crt in this.Controls)
                {
                    if(crt.GetType()==typeof(TextBox))
                    {
                        crt.Text = "";
                    }
                }
                */
                MessageBox.Show("Kupac je dodat!");
                sw.Flush();
                sw.Close();
                sw.Dispose();
                fs.Dispose();
            }


        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(lstListaKupaca.SelectedIndex!=-1)
            {
                string nekiString = lstListaKupaca.SelectedItem.ToString();
                string[] elemStringa = nekiString.Split(' ');
                if (txtImeKupca.Text.Trim().Length != 0 && txtPrezimeKupca.Text.Trim().Length != 0 && txtJmbgKupca.Text.Trim().Length != 0 && txtTelefon.Text.Trim().Length != 0)
                {
                    string telefon = Convert.ToInt64(txtTelefon.Text).ToString("0##-###-####");
                    kupac = new Kupac(idbr, txtImeKupca.Text, txtPrezimeKupca.Text, txtJmbgKupca.Text, dateTimePicker1.Value, telefon);

                    List<string> lista = File.ReadAllLines(putanja).ToList();
                    lista.Insert(lstListaKupaca.SelectedIndex, kupac.ToString());
                    lista.RemoveAt(lstListaKupaca.SelectedIndex + 1);
                    File.WriteAllLines((putanja), lista.ToArray());
                    lstListaKupaca.Items.Insert(lstListaKupaca.SelectedIndex, kupac);
                    lstListaKupaca.Items.RemoveAt(lstListaKupaca.SelectedIndex);
                    txtImeKupca.Clear();
                    txtPrezimeKupca.Clear();
                    txtJmbgKupca.Clear();
                    txtTelefon.Clear();
                    MessageBox.Show("Izmenjeni su podaci od kupca");

                }


            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lstListaKupaca.SelectedIndex != -1)
            {
               
                List<string> lista = File.ReadAllLines(putanja).ToList();

                lista.RemoveAt(lstListaKupaca.SelectedIndex);

                File.WriteAllLines((putanja), lista.ToArray());

                string[] linije = File.ReadAllLines(putanja);

              

               

                lstListaKupaca.Items.RemoveAt(lstListaKupaca.SelectedIndex);

                MessageBox.Show("Kupac je obrisan");
            }
            else
                MessageBox.Show("Niste izabrali kupca");
        }

     

        private void Kupac1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(putanja);
            lstListaKupaca.Items.AddRange(lines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            this.Close();
            admin.Show();
        }
    }
    }

