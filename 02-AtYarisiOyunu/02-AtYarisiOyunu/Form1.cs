using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_AtYarisiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int atHizi1 = rnd.Next(15);
            int atHizi2 = rnd.Next(15);
            int atHizi3 = rnd.Next(15);

            pictureBox1.Location = new Point(pictureBox1.Location.X + atHizi1, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox2.Location.X + atHizi2, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(pictureBox3.Location.X + atHizi1, pictureBox3.Location.Y);

            if (pictureBox1.Location.X+pictureBox1.Width>=pnlBitis.Location.X)
            {
                this.Text = "Yarış Bitti";
                timer1.Stop();
                MessageBox.Show("Tebrikler 1. At Kazanmıştır.","BİLGİ");
            }
            else if (pictureBox2.Location.X + pictureBox2.Width >= pnlBitis.Location.X)
            {
                this.Text = "Yarış Bitti"; ;
                timer1.Stop();
                MessageBox.Show("Tebrikler 2. At Kazanmıştır.","BİLGİ");
            }
            else if (pictureBox3.Location.X + pictureBox3.Width >= pnlBitis.Location.X)
            {
                this.Text = "Yarış Bitti";
                timer1.Stop();
                MessageBox.Show("Tebrikler 3. At Kazanmıştır.","BİLGİ");
            }
        }
    }
}
