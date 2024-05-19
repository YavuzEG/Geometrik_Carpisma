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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float nx = 0, ny = 0, nz = 0, cx = 0, cy = 0, cz = 0, cyarıcap = 0;//Değişken Tanımlama yaptım
            nx = Convert.ToSingle(textBox1.Text);//Textboxdan aldığım değerleri değişkenlere atadım
            ny = Convert.ToSingle(textBox2.Text);
            nz = Convert.ToSingle(textBox7.Text);

            cx = Convert.ToSingle(textBox4.Text);
            cy = Convert.ToSingle(textBox6.Text);
            cz = Convert.ToSingle(textBox5.Text);
            cyarıcap = Convert.ToSingle(textBox3.Text);

            //Çarpışma Kontrolü
            if (cyarıcap >= Math.Sqrt(Math.Pow(cy - ny, 2) + Math.Pow(cx- nx, 2) + Math.Pow(cz-nz,2)))
                label9.Text = "Çarpışma Var";
            else
                label9.Text = "Çarpışma Yok";

            Graphics g = pictureBox1.CreateGraphics();

            //Şekilleri çizdridrdim
            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (cx - cyarıcap) * 4, 150 - (cy + cyarıcap) * 4, cyarıcap * 8, cyarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (cx - cyarıcap) * 4, 150 - (cy + cyarıcap) * 4, cyarıcap * 8, cyarıcap *8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (cx - cyarıcap) * 4, 150 - (cy+cyarıcap/2) * 4, cyarıcap * 8, cyarıcap * 4);

            g.FillEllipse(new SolidBrush(Color.Red), 150 + nx * 4, 150 - ny * 4, 2, 2);

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Silme Komutu
            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
