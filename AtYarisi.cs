using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarısiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Atlardan biri varış çizgisine vardığında oyunu durdur.
        // Maçı labelde canlı olarak anlat.
        // Hileli Butonlar ekle.1. Ata +15,3. ata +7 ekle, 2. atı -28 geri at. Ama yarış bittiğinde butonlatı pasif hale getir.
        Random hız = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           pictureBox1.Left += hız.Next(1, 10);
           pictureBox2.Left += hız.Next(1, 10);
           pictureBox3.Left += hız.Next(1, 10);
         
            if (pictureBox1.Right>pictureBox2.Right&& pictureBox1.Right>pictureBox3.Right)
            {
                labelA.Text = "Yarışı 1 numaralı kulvardaki at önde götürüyor";
            }
            else if(pictureBox2.Right>pictureBox1.Right&& pictureBox2.Right>pictureBox3.Right)
            {
                labelA.Text = "Yarışı 2 numaralı kulvardaki at önde götürüyor";
            }
            else if (pictureBox3.Right > pictureBox1.Right && pictureBox3.Right > pictureBox2.Right)
            {
                labelA.Text = "Yarışı 3 numaralı kulvardaki at önde götürüyor";
            }

            if (pictureBox1.Right > pictureBox2.Right && pictureBox1.Right > pictureBox3.Right&& pictureBox1.Right>=label3.Left)
            { 
                labelA.Text = "Yarışı 1 numaralı kulvardaki at kazandı";
                timer1.Stop();
                timer2.Stop();
            }
            else if (pictureBox2.Right > pictureBox1.Right && pictureBox2.Right > pictureBox3.Right&&pictureBox2.Right>=label3.Left)
            {
                labelA.Text = "Yarışı 2 numaralı kulvardaki at kazandı";
                timer1.Stop();
                timer2.Stop();
            }
            else if (pictureBox3.Right > pictureBox1.Right && pictureBox3.Right > pictureBox2.Right&&pictureBox3.Right>=label3.Left)

            {
                labelA.Text = "Yarışı 3 numaralı kulvardaki at kazandı";
                timer1.Stop();
                timer2.Stop();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
            timer1.Stop();
            labelA.Text = "Yarış Başlamak Üzere";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 15;
            if (pictureBox1.Right >= label3.Left)
            {
                MessageBox.Show("Yarış zaten bitti ulan Ne hilesi");
                button3.Enabled = button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Left -= 28;
            if (pictureBox2.Left < 0) 
            {
                MessageBox.Show("At başlangıç çizgizinden geriye gidemez");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Left += 7;
            if(pictureBox3.Right>=label3.Left)
            {
                MessageBox.Show("Yarış zaten bitti ulan Ne hilesi");
                button3.Enabled = button4.Enabled = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelCA.BackColor = Color.FromArgb(hız.Next(0, 256), hız.Next(0, 256), hız.Next(0, 256));
        }
    }
}
