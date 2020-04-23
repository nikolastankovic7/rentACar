using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace TvpProjekatNrt36_17
{
    public partial class Grafika1 : Form
    {
        private static float br = 0;
        Graphics g;
        FileStream Fs;
        string putanja = "ponuda.txt";
        Administrator admin;
        private float ukupnoponuda;
        public Grafika1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); //dd/MM/yyyy
            InitializeComponent();
        }
        public Grafika1(Administrator admin) : this()
        {
            this.admin = admin;
        }
    

        private void rbAdministrator_MouseHover(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;

            

            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');
               // DateTime mesec = DateTime.ParseExact(elemPonude[1], "dd/MMM/yy",null);
                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 1)
                {
                    broj++;
                }


            }
           ukupnoponuda= listBox1.Items.Count;
           float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);

            string putanja2  = "rezervacija.txt";
            string[] lines1 = File.ReadAllLines(putanja2);

            foreach (string line in lines1)
            {
                string[] elemRezer = line.Split(' ');

            }

            label5.Text = broj.ToString();
        
          
        }

        private void Grafika1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(putanja);
            listBox1.Items.AddRange(lines);
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;


           

            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');
              
                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 2)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);

           

            label5.Text = broj.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;


          

            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 3)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);



            label5.Text = broj.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;


          

            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 4)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);



            label5.Text = broj.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;


           

            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 5)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);



            label5.Text = broj.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;


        
            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 6)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);



            label5.Text = broj.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;



            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 7)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);



            label5.Text = broj.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;



            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 8)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);



            label5.Text = broj.ToString();

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;



            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 9)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);
            label5.Text = broj.ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;



            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 10)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);
            label5.Text = broj.ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;



            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 11)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);
            label5.Text = broj.ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            string putanja = "ponuda.txt";
            string[] lines = File.ReadAllLines(putanja);
            int broj = 0;



            foreach (string line in lines)
            {
                ukupnoponuda++;

                string[] elemPonude = line.Split(' ');

                // na indeksima 1 i 4 nalazi se datum, 2 i 5 vreme
                DateTime mesec = DateTime.Parse(elemPonude[1].ToString());
                //jos jedna promenljiva za drugi datum
                if (mesec.Month == 12)
                {
                    broj++;
                }


            }
            ukupnoponuda = listBox1.Items.Count;
            float num365 = (broj / ukupnoponuda) * 360;
            g = panel2.CreateGraphics();
            g.FillEllipse(Brushes.Blue, new Rectangle(new Point(100, 150), new Size(120, 120)));
            g.FillPie(Brushes.OrangeRed, new Rectangle(new Point(100, 150), new Size(120, 120)), -90, num365);
            label5.Text = broj.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            this.Close();
            administrator.Show();
        }
    }
}
