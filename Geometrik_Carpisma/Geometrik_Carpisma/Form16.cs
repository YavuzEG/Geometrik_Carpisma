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
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ÖDEV_FORM
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            float kx , ky , kz , kyarıcap , dx , dy , dz , dxuzun , dyuzun , dzuzun ;//Değişkenler Oluşturdum

            //Textboxdadki değerleri değişknelere atadım.
            kx = Convert.ToSingle(textBox4.Text); 
            ky = Convert.ToSingle(textBox6.Text);
            kz = Convert.ToSingle(textBox5.Text);
            kyarıcap= Convert.ToSingle(textBox3.Text);

            dx = Convert.ToSingle(textBox8.Text);
            dy = Convert.ToSingle(textBox10.Text);
            dz = Convert.ToSingle(textBox1.Text);
            dxuzun= Convert.ToSingle(textBox7.Text);
            dyuzun= Convert.ToSingle(textBox2.Text);
            dzuzun= Convert.ToSingle(textBox9.Text);


            //Çarpışma KkONTROLÜ
            if (Math.Sqrt(dxuzun * dxuzun + dyuzun * dyuzun + dzuzun*dzuzun) + kyarıcap >= Math.Sqrt(Math.Pow(kx - dx, 2) + Math.Pow(ky - dy, 2) + Math.Pow(kz-dz,2)))
                label17.Text = "Çarpışma Var";
            else
                label17.Text = "Çarpışma Yok";

        //Şekilleri Çizdirme

        Graphics g = pictureBox1.CreateGraphics();

        //Dikdörtgen Prizma Çizimleri
        g.FillRectangle(new SolidBrush(Color.Red), 150 + (dx - dxuzun) * 4 + dzuzun* 4, 150 - (dy + dyuzun) * 4 - dzuzun* 2, dxuzun* 8, dyuzun* 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4 + dzuzun* 4, 150 - (dy + dyuzun) * 4 - dzuzun* 2, dxuzun* 8, dyuzun* 8);


            g.FillRectangle(new SolidBrush(Color.Red), 150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun* 8, dyuzun* 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun* 8, dyuzun* 8);

            g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx - dxuzun) * 4 + dzuzun* 4, 150 - (dy + dyuzun) * 4 - dzuzun* 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun* 4, 150 - (dy + dyuzun) * 4 - dzuzun* 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy - dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun* 4, 150 - (dy - dyuzun) * 4 - dzuzun* 2));

            //Küre Çizdirme
            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap / 2) * 4, kyarıcap * 8, kyarıcap * 4);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Sildirme BUTONNU

            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label17.Text = "";
        }
    }
}
