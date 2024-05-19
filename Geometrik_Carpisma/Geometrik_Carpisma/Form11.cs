/****************************************************************************
**                          SAKARYA ÜNİVERSİTESİ
**              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                   PROGRAMLAMAYA GİRİŞİ DERSİ
**
**                       ÖDEV NUMARASI : 1
**                       ÖĞRENCİ ADI : Yavuz Emre Gündüz
**                       ÖĞRENCİ NUMARASI : B221210071
**                       DERS GRUBU :  A
**                       YOUTUBE LİNKİ : https://youtu.be/ZyMNOZTj1So
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ÖDEV_FORM
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float c1x = 0, c1y = 0, c1z = 0,c1yarıcap=0, c2x = 0, c2y = 0, c2z = 0, c2yarıcap = 0;//Değişken Tanımlama yaptım

            c1x = Convert.ToSingle(textBox1.Text);//Teextbosdaki değerleri değişkenlre tanımladım
            c1y = Convert.ToSingle(textBox2.Text);
            c1z = Convert.ToSingle(textBox3.Text);
            c1yarıcap = Convert.ToSingle(textBox4.Text);

            c2x = Convert.ToSingle(textBox5.Text);
            c2y = Convert.ToSingle(textBox6.Text);
            c2z = Convert.ToSingle(textBox7.Text);
            c2yarıcap = Convert.ToSingle(textBox8.Text);

            //Çarpışma Kontrolü

            if (c1yarıcap +c2yarıcap >= Math.Sqrt(Math.Pow(c1y - c2y, 2) + Math.Pow(c1x - c2x, 2) + Math.Pow(c1z - c2z, 2)))
                label13.Text = "Çarpışma Var";
            else
                label13.Text = "Çarpışma Yok";

            Graphics g = pictureBox1.CreateGraphics();


            //Şekilleri çizdirdim
            g.FillEllipse(new SolidBrush(Color.Red), 150 + (c1x - c1yarıcap) * 4, 150 - (c1y + c1yarıcap) * 4, c1yarıcap * 8, c1yarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (c1x - c1yarıcap) * 4, 150 - (c1y + c1yarıcap) * 4, c1yarıcap * 8, c1yarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (c1x - c1yarıcap) * 4, 150 - (c1y + c1yarıcap / 2) * 4, c1yarıcap * 8, c1yarıcap * 4);

            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (c2x - c2yarıcap) * 4, 150 - (c2y + c2yarıcap) * 4, c2yarıcap * 8, c2yarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (c2x - c2yarıcap) * 4, 150 - (c2y + c2yarıcap) * 4, c2yarıcap * 8, c2yarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (c2x - c2yarıcap) * 4, 150 - (c2y + c2yarıcap / 2) * 4, c2yarıcap * 8, c2yarıcap * 4);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            //Sildirme BUTONNU

            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label13.Text = "";
        }
    }
}
