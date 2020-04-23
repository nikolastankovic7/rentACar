using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvpProjekatNrt36_17
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            this.FormClosing += Administrator_FormClosing;
        }

        private void rbAdministrator_MouseEnter(object sender, EventArgs e)
        {
            //ovo uraditi svuda, proslediti prethodnu formu
            Automobili1 form2 = new Automobili1(this);
            form2.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Kupac1 kup = new Kupac1(this);
            Kupac1 kp = new Kupac1();
            kp.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ponuda1 pp = new Ponuda1();
            pp.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Rezervacija1 rez = new Rezervacija1();
            rez.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Grafika1 graf = new Grafika1();
            graf.Show();
            this.Hide();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           
           this.Close();
        }
    }
}
