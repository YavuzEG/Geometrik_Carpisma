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

        
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            float dx = 0, dy = 0, den = 0, dboy = 0, cx = 0, cy = 0, cyarıcap = 0;//Değişken tanımladım

            dx = Convert.ToSingle(textBox5.Text); //Texboxxdaki değerleri değişkenlere atadım.
            dy = Convert.ToSingle(textBox7.Text);
            den = Convert.ToSingle(textBox2.Text) / 2;
            dboy= Convert.ToSingle(textBox1.Text) / 2;

            cx = Convert.ToSingle(textBox4.Text);
            cy = Convert.ToSingle(textBox6.Text);
            cyarıcap = Convert.ToSingle(textBox3.Text);


            //Çarpışma Kontrolü
            if (Math.Sqrt(den * den + dboy * dboy) + cyarıcap >= Math.Sqrt(Math.Pow(cx - dx, 2) + Math.Pow(cy - dy, 2)))
                label9.Text = "Çarpışma Var";
            else
                label9.Text = "Çarpışma Yok";


            Graphics g = pictureBox1.CreateGraphics();


            //Şekilleri çizdridrdim
            g.FillRectangle(new SolidBrush(Color.Red), 150 + (dx - den) * 4, 150 - (dy + dboy) * 4, den * 8, dboy * 8);

            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (cx - cyarıcap) * 4, 150 - (cy + cyarıcap) * 4, cyarıcap * 8, cyarıcap * 8);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Silme Komutu
            pictureBox1.Image = null;
            foreach(Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }
    }
}
