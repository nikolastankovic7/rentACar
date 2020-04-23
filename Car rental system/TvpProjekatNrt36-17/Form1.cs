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
    public partial class Form1 : Form
    {
        FileStream fs;
        string putanja;

        public Form1()
        {
            InitializeComponent();
            putanja = "tekregistrovanikorisnici.txt";
            txtPassword.PasswordChar = '*';
           
        }


        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Morate uneti korisnicko ime!");
            }
            else if (txtKorisnickoIme.Text == " ") 
                {
                MessageBox.Show("Morate uneti korisnicko ime!");

            }
          if(txtPassword.Text=="")
            {
                MessageBox.Show("Morate uneti vasu lozinku");
            }
          else if(txtPassword.Text==" ")
            {
                MessageBox.Show("Morate uneti vasu lozinku");
            }
          if(txtKorisnickoIme.Text=="nikola")
            {
                if(txtPassword.Text=="nikola")
                {
                    if(cbAdministrator.Checked)
                    {
                        Administrator f3 = new Administrator();
                        f3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nazalost, pozicija administratora vam nije dodeljena");
                        return;
                    }
                }
                

            }

         
          if(cbKorisnik.Checked)
            {

                StreamReader sr = new StreamReader("tekregistrovanikorisnici.txt");
                string linija = "";
                if ((linija = sr.ReadLine()).Contains( txtKorisnickoIme.Text) )
                {
                    MessageBox.Show("Uspešno ste se prijavili, prebacujemo vas na deo za korisnike");
                    Korisnici1 kup = new Korisnici1();
                    kup.Show();
                    this.Hide();
                  
                }
                else
                {
                    MessageBox.Show("Niste registrovan korisnik, prvo se registrujte");
                    return;
                   
                }

               
               

            }
         
         
        }

        private void btnRegistrujse_Click(object sender, EventArgs e)
        {if(cbAdministrator.Checked)
            {
               
                return;
            }
            if (txtKorisnickoIme.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length !=0)
            {
                if (File.Exists(putanja))
                {
                    fs = new FileStream(putanja, FileMode.Append, FileAccess.Write);
                }
                else
                    fs = new FileStream(putanja, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(txtKorisnickoIme.Text);
                sw.Write(txtPassword.Text);
               
                sw.Flush();
                sw.Close();
                fs.Dispose();
            }
            
               
            if(File.Exists(putanja))
            {
                fs = new FileStream(putanja, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string tekst = sr.ReadToEnd();
               
                MessageBox.Show("Uspesno ste se registrovali");
               
            }
            else
                MessageBox.Show("Nažalost, došlo je do greške!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
            
            }
        
   

