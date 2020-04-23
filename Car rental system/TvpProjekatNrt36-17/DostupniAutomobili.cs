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
    public partial class DostupniAutomobili : Form
    {
        public DostupniAutomobili()
        {
            InitializeComponent();
        }

        private void DostupniAutomobili_Load(object sender, EventArgs e)
        {
            string[] fajlovi = Directory.GetFiles(@"D:\Automobili");
            DataTable table = new DataTable();
            table.Columns.Add("Automobili");
            for (int i = 0; i < fajlovi.Length; i++)
            {
                FileInfo file = new FileInfo(fajlovi[i]);
                table.Rows.Add(file.Name);
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Slike_automobila slike = new Slike_automobila();
            string imageName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Image img;
            img = Image.FromFile(@"D:\Automobili\" + imageName);
            slike.pictureBox1.Image = img;
            slike.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Korisnici1 korisnik = new Korisnici1();
            this.Close();
            korisnik.Show();
        }
    }
}
