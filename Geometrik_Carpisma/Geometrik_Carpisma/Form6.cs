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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ÖDEV_FORM
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float c1x = 0,c1y=0,c1yarıcap=0,c2x=0,c2y=0,c2yarıcap = 0;//Değişken oluştrudum   
            c1x = Convert.ToSingle(textBox3.Text);//Textboxdaki değerleri değişkenlere atadım.
            c1y = Convert.ToSingle(textBox4.Text);
            c1yarıcap = Convert.ToSingle(textBox5.Text);

            c2x = Convert.ToSingle(textBox2.Text);
            c2y = Convert.ToSingle(textBox6.Text);
            c2yarıcap = Convert.ToSingle(textBox1.Text);

            //Çarpışma Kontrolü

            if (c1yarıcap + c2yarıcap >= Math.Sqrt(Math.Pow(c1y - c2y, 2) + Math.Pow(c1x - c2x, 2)))
                label9.Text = "Çarpışma Var";
            else
                label9.Text = "Çarpışma Yok";

            Graphics g = pictureBox1.CreateGraphics();

            //Şekilleri çizdridrdim
            g.FillEllipse(new SolidBrush(Color.Red), 150 + (c1x - c1yarıcap) * 4, 150 - (c1y + c1yarıcap) * 4, c1yarıcap * 8, c1yarıcap * 8);
            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (c2x - c2yarıcap) * 4, 150 - (c2y + c2yarıcap) * 4, c2yarıcap * 8, c2yarıcap * 8);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Sildirme butonu komutu
            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
