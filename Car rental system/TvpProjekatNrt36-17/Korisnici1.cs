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
    public partial class Korisnici1 : Form
    {
        public Korisnici1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DostupniAutomobili dost = new DostupniAutomobili();
            dost.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            this.Close();
            this.Close();
            
        }

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {
            Kupackor kor = new Kupackor();
            kor.Show();
            this.Close();

        }
    }
}
